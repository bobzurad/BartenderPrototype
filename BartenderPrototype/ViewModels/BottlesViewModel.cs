using System;
using System.Collections.ObjectModel;

namespace BartenderPrototype
{
	public class BottlesViewModel
	{
		public ObservableCollection<Bottle> Bottles { get; set; }

		public BottlesViewModel()
		{
			Bottles = new ObservableCollection<Bottle>
			{
				new Bottle {
					ImagePath = "http://www.lcbo.com/content/dam/lcbo/products/243824.jpg/jcr:content/renditions/cq5dam.web.1280.1280.jpeg",
					Name = "Oban 14"
				},
				new Bottle {
					ImagePath = "http://www.lcbo.com/content/dam/lcbo/products/573337.jpg/jcr:content/renditions/cq5dam.web.1280.1280.jpeg",
					Name = "McClelland's"
				},
				new Bottle {
					ImagePath = "http://www.lcbo.com/content/dam/lcbo/products/376210.jpg/jcr:content/renditions/cq5dam.web.1280.1280.jpeg",
					Name = "Tomintoul 12"
				},
				new Bottle {
					ImagePath = "https://media2.caskers.com/media/catalog/product/cache/1/thumbnail/1000x/9df78eab33525d08d6e5fb8d27136e95/o/b/oban-18-year-old-limited-edition-single-malt-scotch-whisky-1.jpg",
					Name = "Oban 18"
				},
				new Bottle {
					ImagePath = "http://www.whisky.fr/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/m/1/m1004_2.jpg",
					Name = "Glen Grant"
				}
			};
		}
	}
}
