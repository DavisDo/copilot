using Copilot_tester.Models;

namespace Copilot_tester;

public class Actions
{
    public List<Pet> Pets { get; set; } = new List<Pet>();
    // using regex add function to update pet number that consists of 5 digits and 1 letter
    public void UpdatePetNumber(Pet pet, string newNumber)
    {
        // #validate new number with regex that it consist of 5 digits and 1 letter
        pet.RegNr = newNumber;
    }
    
    public Pet RegisterNewPet(string name, string owner, int age, string breed, string color, PetType type)
    {
        
        Pet pet = type switch
        {
            PetType.Dog => new Dog(),
            _ => throw new ArgumentException("Invalid pet type")
        };
        pet.Name = name;
        pet.Owner = owner;
        pet.Age = age;
        pet.Breed = breed;
        pet.Color = color;
        return pet;
    }
    
    public void ChangePetName(Pet pet, string newName)
    {
        pet.Name = newName;
    }
    
    public void ChangePetOwner(Pet pet, string newOwner)
    {
        pet.Owner = newOwner;
    }
    
    public PetType GetPetType(Pet pet)
    {
        return pet switch
        {
            Dog _ => PetType.Dog,
            Cat _ => PetType.Cat,
            _ => throw new ArgumentException("Invalid pet type")
        };
    }
    
    public void AddPet(Pet pet, PetType type)
    {
        Pets.Add(pet);
    }
    
    public void RemovePet(Pet pet)
    {
        Pets.Remove(pet);
    }
}