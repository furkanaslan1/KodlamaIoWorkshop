using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoWorkshop.Entities;

public class Course

{
    public Course()
    {
      

    }

    public Course(int ıd, string name, string description, string pictureUrl, bool ısFree, Teacher teacher)
    {
        Id = ıd;
        Name = name;
        Description = description;
        PictureUrl = pictureUrl;
        IsFree = ısFree;
        Teacher = teacher;
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public string PictureUrl { get; set; }

    public bool IsFree { get; set; }

    public Teacher Teacher { get; set; }

    public Category Category{ get; set; }
}



