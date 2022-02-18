namespace PatternMatching.Models
{
    public class Cat
    {
        public Cat(string name, byte age, CatBreed catBreed) =>
            (Name,Age,Breed) = (name,age,catBreed);

        public string Name { get; init; }
        public byte Age { get; init; }
        public CatBreed Breed { get; init; }
    }
}
