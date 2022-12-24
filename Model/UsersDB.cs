using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Documents;

namespace Wpf_HW_2.Model
{
    /// <summary>
    /// данные, используемые приложением
    /// </summary>
    internal class UsersDB
    {
        static UsersDB _context;
        public static UsersDB Context => _context ?? (_context = new UsersDB());

        UsersDB()
        {
            Orders = new ObservableCollection<Order>()
            {
                new Order(){Id = 1, Client = "Клиент1", Date = new DateTime(2022, 12, 10),
                    Products = new ObservableCollection<OrderProduct>()
                    {
                        new OrderProduct(){Product = Products.First(x => x.Id == 1), Quantity = 11},
                        new OrderProduct(){Product = Products.First(x => x.Id == 2), Quantity = 2},
                        new OrderProduct(){Product = Products.First(x => x.Id == 3), Quantity = 2},
                    }
                },

                new Order(){Id = 2, Client = "Клиент2", Date = new DateTime(2022, 12, 11),
                    Products = new ObservableCollection<OrderProduct>()
                    {
                        new OrderProduct(){Product = Products.First(x => x.Id == 4), Quantity = 2},
                        new OrderProduct(){Product = Products.First(x => x.Id == 2), Quantity = 4},
                        new OrderProduct(){Product = Products.First(x => x.Id == 6), Quantity = 3},
                    }
                },

                new Order(){Id = 3, Client = "Клиент3", Date = new DateTime(2022, 12, 12),
                    Products = new ObservableCollection<OrderProduct>()
                    {
                        new OrderProduct(){Product = Products.First(x => x.Id == 3), Quantity = 13},
                        new OrderProduct(){Product = Products.First(x => x.Id == 2), Quantity = 2},
                        new OrderProduct(){Product = Products.First(x => x.Id == 5), Quantity = 3},
                    }
                },

                new Order(){Id = 4, Client = "Клиент4", Date = new DateTime(2022, 12, 10),
                    Products = new ObservableCollection<OrderProduct>()
                    {
                        new OrderProduct(){Product = Products.First(x => x.Id == 6), Quantity = 10},
                        new OrderProduct(){Product = Products.First(x => x.Id == 2), Quantity = 2},
                    }
                },

                new Order(){Id = 5, Client = "Клиент5", Date = new DateTime(2022, 12, 13),
                    Products = new ObservableCollection<OrderProduct>()
                    {
                        new OrderProduct(){Product = Products.First(x => x.Id == 4), Quantity = 1},
                    }
                },

                new Order(){Id = 6, Client = "Клиент6", Date = new DateTime(2022, 12, 13),
                    Products = new ObservableCollection<OrderProduct>()
                    {
                        new OrderProduct(){Product = Products.First(x => x.Id == 4), Quantity = 10},
                        new OrderProduct(){Product = Products.First(x => x.Id == 3), Quantity = 10},
                        new OrderProduct(){Product = Products.First(x => x.Id == 2), Quantity = 12},
                    }
                },
            };

            Folders = new List<Folder>()
            {
                new Folder()
                { 
                    Name = "Конфеты", Nodes = new List<INode>()
                    {
                        new Folder()
                        {
                            Name = "Подпапка", Nodes = new List<INode>()
                            { 
                                new ProductNode(Products.First(x => x.Id == 1))
                            }
                        }, 
                        new ProductNode(Products.First(x => x.Id == 2))
                    }
                },

                new Folder()
                { 
                    Name = "Торты", Nodes = new List<INode>()
                    {
                        {
                            new ProductNode(Products.First(x => x.Id == 3))
                        }
                    }
                },

                new Folder()
                { 
                    Name = "Прочее", Nodes = new List<INode>(Products.ToList().GetRange(3, 3).Select(x => new ProductNode(x)))
                    {
                        {
                            new ProductNode(Products.First(x => x.Id == 3))
                        }
                    }
                }
            };
        }
        /// <summary>
        /// список пользователей
        /// </summary>
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>()
        {
            new User("Name1","Login1","Password1"),
            new User("Name2","Login2","Password2"),
            new User("Name3","Login3","Password3"),
            new User("Name4","Login4","Password4"),
            new User("Name5","Login5","Password5"),
        };
        /// <summary>
        /// список товаров
        /// </summary>
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>()
        {
            new Product(){Id = 1, Name = "Конфета шоколадная", Price = 100M},
            new Product(){Id = 2, Name = "Леденец\"Петушок\"", Price = 50M},
            new Product(){Id = 3, Name = "Вафельнвй торт", Price = 300M},
            new Product(){Id = 4, Name = "Безе цветное", Price = 250M},
            new Product(){Id = 5, Name = "Мармеладные мишки", Price = 349M},
            new Product(){Id = 6, Name = "Цукаты из ананаса", Price = 299M},
        };

        public List<Folder> Folders { get; set; }
        /// <summary>
        /// список заказов
        /// </summary>
        public ObservableCollection<Order> Orders { get; set; }
    }
}
