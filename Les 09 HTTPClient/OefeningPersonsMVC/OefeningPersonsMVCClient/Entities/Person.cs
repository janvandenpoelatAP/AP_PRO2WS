﻿namespace OefeningPersonsMvc.Entities
{
    public enum Gender
    {
        Female,
        Male
    }

    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
    }
}
