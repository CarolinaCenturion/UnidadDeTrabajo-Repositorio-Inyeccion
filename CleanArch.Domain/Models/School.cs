using System;
namespace CleanArch.Domain.Models
{
    public  class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }
    }
}
