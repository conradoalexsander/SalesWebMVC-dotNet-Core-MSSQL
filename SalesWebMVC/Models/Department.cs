using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(string name)
        {
            Name = name;
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            //Utilizando o método TotalSales do vendedor (Classe Seller), passando a data inicial e final, 
            //e realizando a soma de cada seller na lista de Seller do Department
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
