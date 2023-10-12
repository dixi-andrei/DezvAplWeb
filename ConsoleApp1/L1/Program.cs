using L1;

Materie materie1 = new Materie("Fizica", 2, 2);
Materie materie2 = new Materie("Matematica", 3, 1);
Materie materie3 = new Materie("Informatica", 1, 3);

List<Student> studenti = new List<Student>();

Student student1 = new Student("Mitrana", "Fanel", 22);
student1.adaugaMaterie(materie2);
student1.adaugaMaterie(materie3);
studenti.Add(student1);

Student student2 = new Student("Ionascu", "Dragos", 30);
student2.adaugaMaterie(materie1);
student2.adaugaMaterie(materie2);
studenti.Add(student2);

Student student3 = new Student("Cazimirovici", "Wilheim", 28);
student3.adaugaMaterie(materie1);
student3.adaugaMaterie(materie2);
student3.adaugaMaterie(materie3);
studenti.Add(student3);

foreach(Student student in studenti)
{
    student.afiseazaDetalii();
}