﻿using System;
using Newtonsoft.Json;

namespace HelloWorldService.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }
        public Phone[] Phones { get; set; }
    }

    public class Phone
    {
        public string Number { get; set; }
        public PhoneType PhoneType { get; set; }
    }

    public enum PhoneType
    {
        Nil,
        Home,
        Mobile,
    }
}