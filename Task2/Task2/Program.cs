// Massivin uzunlugunu daxil edin
Console.WriteLine("Massivin uzunlugunu daxil edin:");
int n = int.Parse(Console.ReadLine());
int[] mass = new int[n];

// Massivin elementlerini daxil edin
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine($"mass[{i}]=");
    mass[i] = int.Parse(Console.ReadLine());
}

// 1. Massivin cemini tapin
int sum = 0;
for (int i = 0; i < mass.Length; i++)
{
    sum += mass[i];
}
Console.WriteLine("Cem: " + sum);

// 2. Massivin ortalamasini tapin
double average = (double)sum / mass.Length;
Console.WriteLine("Ortalama: " + average);

// 3. Massivde mueyyen bir ededin olub-olmadigini yoxlayin
Console.WriteLine("Axtarmaq istediyiniz ededi daxil edin:");
int searchNum = int.Parse(Console.ReadLine());
bool exists = false;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] == searchNum)
    {
        exists = true;
        break;
    }
}
Console.WriteLine(exists ? "Eded massivde movcuddur" : "Eded massivde yoxdur");

// 4. En kicik ve en boyuk ededleri tapin
int min = mass[0], max = mass[0];
for (int i = 1; i < mass.Length; i++)
{
    if (mass[i] < min) min = mass[i];
    if (mass[i] > max) max = mass[i];
}
Console.WriteLine("En kicik eded: " + min);
Console.WriteLine("En boyuk eded: " + max);

// 5. Cut ededlerin cemini tapin
int evenSum = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] % 2 == 0)
    {
        evenSum += mass[i];
    }
}
Console.WriteLine("Cut ededlerin cemi: " + evenSum);

// 6. Massivin tersine cevrilmis yeni massivini yaradin
int[] reversedMass = new int[n];
for (int i = 0; i < mass.Length; i++)
{
    reversedMass[i] = mass[mass.Length - 1 - i];
}
Console.WriteLine("Tersine cevrilmis massiv:");
for (int i = 0; i < reversedMass.Length; i++)
{
    Console.Write(reversedMass[i] + " ");
}
Console.WriteLine();

// 7. En boyuk iki ededi tapin
int max1 = int.MinValue, max2 = int.MinValue;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > max1)
    {
        max2 = max1;
        max1 = mass[i];
    }
    else if (mass[i] > max2 && mass[i] != max1)
    {
        max2 = mass[i];
    }
}
Console.WriteLine("En boyuk iki eded: " + max1 + " ve " + max2);

// 8. Massivin butun elementlernin iki qatini tapin ve yeni massiv yaradin
int[] doubledMass = new int[n];
for (int i = 0; i < mass.Length; i++)
{
    doubledMass[i] = mass[i] * 2;
}
Console.WriteLine("Ikiqat massiv:");
for (int i = 0; i < doubledMass.Length; i++)
{
    Console.Write(doubledMass[i] + " ");
}
Console.WriteLine();








// 9. Insanin yasini heasblayan program

Console.WriteLine("Dogum tarixini daxil et (gun ay il) and current date (gun ay il):");
string[] input = Console.ReadLine().Split(' ');

int birthDay = int.Parse(input[0]);
int birthMonth = int.Parse(input[1]);
int birthYear = int.Parse(input[2]);
int currentDay = int.Parse(input[3]);
int currentMonth = int.Parse(input[4]);
int currentYear = int.Parse(input[5]);

int age = currentYear - birthYear;

if (currentMonth < birthMonth || (currentMonth == birthMonth && currentDay < birthDay))
{
    age--;
}

Console.WriteLine($"{age} yash");