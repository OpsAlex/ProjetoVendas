using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FormularioVendasMVC.Models

{
    public class Seller
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage ="{0} Required")]
        [StringLength(60, MinimumLength =3, ErrorMessage ="O {0} deve conter entre {2} até {1} caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //Custumizando como irá aparecer
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "{0} Required")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Salario Base")]
        [Required(ErrorMessage = "{0} Required")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }
        [Display(Name = "Departamento")]
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}