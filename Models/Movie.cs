using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTickets.Data;
using eTickets.Models;


namespace eTickets.Models{

    public class Movie
    {
        [Key]
        public int Id { get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public string ImageURL {get; set;}
        public DateTime StartDate {get; set;}
        public DateTime EndDate { get; set;}
        public MovieCategory MovieCategory {get; set;}

        //Relationships
        public List<Actor_Movie> Actors_Movies{get;set;}

        //Cinema
        public int CinemaId {get;set;}
        [ForeignKey("CinemaId")]
        public Cinema cinema{ get;set;}

        //Producer
        public int ProducerId {get;set;}
        [ForeignKey("ProducerId")]
        public Producer producer { get;set;}
    }   
}