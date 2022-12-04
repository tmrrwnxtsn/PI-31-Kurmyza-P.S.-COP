using FurnitureFactoryPluginManager.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;

namespace FurnitureFactoryPluginManager
{
    public class PluginManager
    {
        [ImportMany(typeof(IPluginsConvention))]
        IEnumerable<IPluginsConvention> Plugins { get; set; }

        public readonly Dictionary<string, IPluginsConvention> plugins_dictionary = new Dictionary<string, IPluginsConvention>();

        public PluginManager()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory));
            catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins")));

            //Контейнер композиции
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            if (Plugins.Any())
            {
                Plugins
                    .ToList()
                    .ForEach(p =>
                    {
                        if (!plugins_dictionary.Keys.Contains(p.PluginName))
                            plugins_dictionary.Add(p.PluginName, p);
                    });
            }
        }
    }
}
