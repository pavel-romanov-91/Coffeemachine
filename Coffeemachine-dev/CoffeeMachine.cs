namespace coffeemachine
{
    public class CoffeeMachine
    {
        private bool isOn;
        private int waterLevel;
        private int milkLevel;
        private int coffeeLevel;
        private List<string> logs;
        private List<Drink> preparedDrinks;
        private Dictionary<string, string>recipes;

        public CoffeeMachine()
        {
            isOn = false;
            waterLevel = 0;
            milkLevel = 0;
            coffeeLevel = 0;
            logs = new List<string>();
            preparedDrinks = new List<Drink>();
            recipes = new Dictionary<string, string>();

            recipes.Add("Espresso","1. Положите 30 мл воды. \n2. Добавте 10 г кофе. \n3. Приготовьте.");
            recipes.Add("Cappuccino", "1. Положите 30 мл воды. \n2. Добавте 10 г кофе. \n3. Добавте 20 г кофе.\n4. Приготовьте.");
        }
        public void TurnOn()
        {
            isOn = true;
            logs.Add("Кофемашина включена.");
        }
        public void TurnOff()
        {
            isOn = false;
            logs.Add("Кофемашина выключина.");
        }
        public void AddWater(int amount)
        {
            if(isOn)
            {
                waterLevel += amount;
                logs.Add($"Добавлено{amount}мл воды.");
            }
            else
            {
                logs.Add("Нельзя добавить воду. Кофемашина выключина");
            }
        }
        public void AddMilk(int amount)
        {
            if(isOn)
            {
                milkLevel += amount;
                logs.Add($"Добавлено{amount}мл молоко.");
            }
            else
            {
                logs.Add("Нельзя добавить молоко. Кофемашина выключина");
            }
        }
        public void AddCoffee(int amount)
        {
            if(isOn)
            {
                coffeeLevel += amount;
                logs.Add($"Добавлено{amount}г кофе.");
            }
            else
            {
                logs.Add("Нельзя добавить кофе. Кофемашина выключина");
            }
        }
        public int CheckWater()
        {
            return waterLevel;
        }
        public int CheckMilk()
        {
            return milkLevel;
        }
        public int CheckCoffee()
        {
            return coffeeLevel;
        }
        public void Clean()
        {
            if(isOn)
            {
                logs.Add("Чистка кофемашины.");
                waterLevel =0;
                milkLevel =0;
                coffeeLevel =0;
            }
            else
            {
                logs.Add("Невозможно выполнить чистку. Кофемашиина выключена.");
            }
        }
        public void BrewEspresso(DrinkSize size, int cups)
        {
            int waterNeeded = 30 * (int)size * cups;
            int coffeeNeeded = 10 * (int)size * cups;

            if(isOn && waterLevel >= waterNeeded && coffeeLevel >= coffeeNeeded)
            {
                logs.Add($"Приготовлен Эспрессо ({size.ToString()}x{cups})");
                waterLevel -= waterNeeded;
                coffeeLevel -= coffeeNeeded;
                preparedDrinks.Add(new Drink("Espresso", size, cups));
            }
            else
            {
                logs.Add("Недостаточно ресурсов для приготовления Эспрессо");
            }
        }
        public void BrewCappuccino(DrinkSize size, int cups)
        {
            int waterNeeded = 30 * (int)size * cups;
            int coffeeNeeded = 10 * (int)size * cups;
            int milkNeeded = 20 * (int)size * cups;

            if(isOn && waterLevel >= waterNeeded && coffeeLevel >= coffeeNeeded && milkLevel >= milkNeeded)
            {
                logs.Add($"Приготовлен Капучино ({size.ToString()}x{cups})");
                waterLevel -= waterNeeded;
                coffeeLevel -= coffeeNeeded;
                milkLevel -= milkNeeded;
                preparedDrinks.Add(new Drink("Cappuccino", size, cups));
            }
            else
            {
                logs.Add("Недостаточно ресурсов для приготовления Капучино");
            }
        }
        public void PrintRecipe(string Espresso)
        {
            if (recipes.ContainsKey(Espresso))
            {
                Console.WriteLine($"Рецепт для {Espresso}");
                Console.WriteLine(recipes[Espresso]);
            }
            else
            {
                Console.WriteLine($"Рецепт для {Espresso} не найден");
            }
        }
        public List<Drink>GetPreparedDrinks()
        {
            return preparedDrinks;
        }
        public void Log()
        {
            foreach(string log in logs)
            {
                Console.WriteLine(log);
            }
        }

    }

}