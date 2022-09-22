using System.ComponentModel.DataAnnotations;

namespace Commander.Models //namespace: the name of our project (similar to Java package (?))
{
    public class Command
    {
        //[Required] not needed because by conventional configuration, id is primary key (not nullable by nature)
        // [] ->  data annotations
        [Key] //optional
        public int Id { get; set; }

        [Required] //NOT NULL
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; } //command line snippet we'll store in database

        [Required]
        public string Platform { get; set; } //application platform 
    }
}

// create migration file after mentioning [required] for nullable: false