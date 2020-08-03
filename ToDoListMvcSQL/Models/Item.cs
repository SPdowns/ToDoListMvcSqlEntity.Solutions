using System.Collections.Generic;
using System;

namespace ToDoListMvcSql.Models
{
  public class Item
  {
    public Item()
    {
      this.Categories = new HashSet<CategoryItem>();
      IsComplete = false;
    }
    public int ItemId { get; set; }
    public string Description { get; set; }
    public bool IsComplete { get; set; }
    public DateTime DueDate { get; set; }
    public ICollection<CategoryItem> Categories { get; }
  }
}