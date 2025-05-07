namespace program_Health
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int playerHealth = 85;

                Console.WriteLine("Health before potion: " + playerHealth);

                UseHealthPotion(ref playerHealth);

                Console.WriteLine("Health after potion: " + playerHealth);
            }

            static void UseHealthPotion(ref int health, int potion = 20)
            {
                health += potion;

                if (health > 100)
                {
                    health = 100;
                }
            }
        }
    }
}