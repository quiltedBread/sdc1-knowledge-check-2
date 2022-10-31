class Fruit : Food
{
    public bool IsBanana { get; set; }

    public Fruit(bool isBanana, string name) : base(name)
    {
        IsBanana = isBanana;
    }

    public override string ToString()
    {
        return base.ToString() + $": is {(IsBanana ? "" : "not")} a banana";
    }
}
