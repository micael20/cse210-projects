public class ShipGallery
{
    private List<ShipClass> _ships = new List<ShipClass>();

    // Responsibility 1: ADD SHIPS TO COLLECTION
    public void AddShip(string shipName, int length, int breadth, int draft, int displacement)
    {
        ShipClass newShip = new ShipClass(length, breadth, draft, displacement);
        _ships.Add(newShip);

        // You could also store the ship name if you modify ShipClass
        Console.WriteLine($"Added {shipName} to gallery!");
    }

    // Responsibility 2: DISPLAY ALL SHIP COEFFICIENTS
    public void DisplayAllBlockCoefficients()
    {
        Console.WriteLine("=== SHIP BLOCK COEFFICIENTS ===");

        for (int i = 0; i < _ships.Count; i++)
        {
            // 🎯 CRC MAGIC: Don't ask HOW, just ask TO DO THE JOB!
            double coefficient = _ships[i].GetBlockCoeffcient();
            Console.WriteLine($"Ship {i + 1}: Block Coefficient = {coefficient}");
        }
    }
}