/* Exercise is on page 267. for some reason this later verion of VS im using does not need or want the static keywords
 * that the book asks you to implement for random and RollDice */
using SwordDamageFormulaEncapsulated;

Random random = new Random();

SwordDamage swordDamage = new SwordDamage(RollDice());

Console.WriteLine("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
char input = Console.ReadKey().KeyChar;

if (input != '0' && input != '1' && input != '2' && input != '3') return;
swordDamage.Roll = RollDice();

swordDamage.Magic = (input == '1' || input == '3');
swordDamage.Flaming = (input == '2' || input == '3');

Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP\n");

int RollDice()
{
    return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
}
// next step is part 3 pm [age 267