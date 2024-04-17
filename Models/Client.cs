﻿using System.ComponentModel.DataAnnotations;

namespace WatchMNS.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Password { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public string NativeCity { get; set; }
        public string NativeCountry { get; set; }
        public int ProfessionnalStatusId { get; set; }
        public int RoleId { get; set; }
        public List<Training>? Trainings { get; set; } = new List<Training>();
        public List<Notification>? Notifications { get; set; } = new List<Notification>();
    }
}