﻿namespace PetApi.Model
{
  public class Pet
  {
    public Pet(string name, string type, string color, int price)
    {
      Name = name;
      Type = type;
      Color = color;
      Price = price;
    }

    public string Name { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
    public int Price { get; set; }

    public override bool Equals(object? obj)
    {
      return obj is Pet pet
             && Name.Equals(pet.Name)
             && Type.Equals(pet.Type)
             && Color.Equals(pet.Color)
             && Price.Equals(pet.Price);
    }

    public override int GetHashCode()
    {
      throw new System.NotImplementedException();
    }
  }
}
