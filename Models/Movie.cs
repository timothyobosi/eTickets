
using System.ComponentModel.DataAnnotations;
using eTickets.Data;

namespace eTickets.Models{

    [Key]
    public int Id {get; set;}
    public string Name{get; set;}
    public string Description{get;set;}
    public double Price {get;set;}

    public string ImageURL {get; set;}
    public DateTime StartDate {get; set;}
    public DateTime EndDate {get;set;}
    //movie category
         //create enum instead of datatype   //name
    public MovieCategory MovieCategory {get; set;}
}