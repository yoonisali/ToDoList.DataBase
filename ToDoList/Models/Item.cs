using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int Id { get; set; }
  }
}
