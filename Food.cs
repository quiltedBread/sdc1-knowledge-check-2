class Food
{
    public string Name { get; set; }

    public Food(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}
