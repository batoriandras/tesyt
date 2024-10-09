namespace oraimunka
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Name = "Kovács István",
                    NeptunCode = "ABC123",
                    BirthYear = 1998,
                    EnrollmentYear = 2017,
                    CompletedCredits = 180,
                    Absolved = true,
                    Graduated = false,
                    Subjects = new List<Subject>
                    {
                        new Subject
                        {
                            Credit = 6,
                            Name = "Matematikai alapismeretek",
                            Code = "MATH101",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Dr. Szabó Zoltán",
                                    NeptunCode = "XYZ789",
                                    BirthYear = 1975,
                                    StartOfEmployment = new DateTime(2000, 9, 1),
                                    HasPhd = true
                                }
                            }
                        },
                        new Subject
                        {
                            Credit = 5,
                            Name = "Adatbázisok",
                            Code = "DB102",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Dr. Kiss Péter",
                                    NeptunCode = "PQR123",
                                    BirthYear = 1970,
                                    StartOfEmployment = new DateTime(1998, 5, 10),
                                    HasPhd = true
                                },
                                new Teacher
                                {
                                    Name = "Nagy Gábor",
                                    NeptunCode = "LMN456",
                                    BirthYear = 1980,
                                    StartOfEmployment = new DateTime(2005, 2, 15),
                                    HasPhd = false
                                }
                            }
                        }
                    }
                },
                new Student
                {
                    Name = "Nagy Anna",
                    NeptunCode = "DEF456",
                    BirthYear = 1999,
                    EnrollmentYear = 2018,
                    CompletedCredits = 120,
                    Absolved = true,
                    Graduated = false,
                    Subjects = new List<Subject>
                    {
                        new Subject
                        {
                            Credit = 4,
                            Name = "Analízis I.",
                            Code = "ANAL101",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Dr. Varga László",
                                    NeptunCode = "UVW654",
                                    BirthYear = 1968,
                                    StartOfEmployment = new DateTime(1995, 4, 12),
                                    HasPhd = true
                                }
                            }
                        },
                        new Subject
                        {
                            Credit = 4,
                            Name = "Fizika",
                            Code = "PHY101",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Molnár Katalin",
                                    NeptunCode = "EFG321",
                                    BirthYear = 1982,
                                    StartOfEmployment = new DateTime(2007, 8, 15),
                                    HasPhd = false
                                }
                            }
                        }
                    }
                },
                new Student
                {
                    Name = "Szabó Dávid",
                    NeptunCode = "GHI789",
                    BirthYear = 1997,
                    EnrollmentYear = 2016,
                    CompletedCredits = 210,
                    Absolved = true,
                    Graduated = true,
                    Subjects = new List<Subject>
                    {
                        new Subject
                        {
                            Credit = 6,
                            Name = "Tanulásmódszertan",
                            Code = "LEARN101",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Dr. Farkas Béla",
                                    NeptunCode = "ABC321",
                                    BirthYear = 1972,
                                    StartOfEmployment = new DateTime(2001, 11, 1),
                                    HasPhd = true
                                }
                            }
                        },
                        new Subject
                        {
                            Credit = 4,
                            Name = "Számítógép hálózatok",
                            Code = "NET103",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Kovács László",
                                    NeptunCode = "HJK654",
                                    BirthYear = 1978,
                                    StartOfEmployment = new DateTime(2003, 3, 10),
                                    HasPhd = false
                                }
                            }
                        }
                    }
                },
                new Student
                {
                    Name = "Horváth Ádám",
                    NeptunCode = "JKL012",
                    BirthYear = 2000,
                    EnrollmentYear = 2019,
                    CompletedCredits = 90,
                    Absolved = false,
                    Graduated = false,
                    Subjects = new List<Subject>
                    {
                        new Subject
                        {
                            Credit = 5,
                            Name = "Informatikai biztonság",
                            Code = "SEC102",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Dr. Horváth Ferenc",
                                    NeptunCode = "LMN543",
                                    BirthYear = 1965,
                                    StartOfEmployment = new DateTime(1990, 6, 20),
                                    HasPhd = true
                                }
                            }
                        },
                        new Subject
                        {
                            Credit = 6,
                            Name = "Elektronikai alapismeretek",
                            Code = "ELEC101",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Tóth Eszter",
                                    NeptunCode = "STU987",
                                    BirthYear = 1985,
                                    StartOfEmployment = new DateTime(2010, 9, 1),
                                    HasPhd = false
                                }
                            }
                        }
                    }
                },
                new Student
                {
                    Name = "Tóth László",
                    NeptunCode = "MNO345",
                    BirthYear = 1996,
                    EnrollmentYear = 2015,
                    CompletedCredits = 240,
                    Absolved = true,
                    Graduated = true,
                    Subjects = new List<Subject>
                    {
                        new Subject
                        {
                            Credit = 6,
                            Name = "Problema megoldás programozással",
                            Code = "PROG102",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Nagy Gábor",
                                    NeptunCode = "LMN456",
                                    BirthYear = 1980,
                                    StartOfEmployment = new DateTime(2005, 2, 15),
                                    HasPhd = false
                                },
                                new Teacher
                                {
                                    Name = "Dr. Varga László",
                                    NeptunCode = "UVW654",
                                    BirthYear = 1968,
                                    StartOfEmployment = new DateTime(1995, 4, 12),
                                    HasPhd = true
                                }
                            }
                        },
                        new Subject
                        {
                            Credit = 6,
                            Name = "Az informatika matematikai alapjai",
                            Code = "CSMATH101",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Dr. Szabó Zoltán",
                                    NeptunCode = "XYZ789",
                                    BirthYear = 1975,
                                    StartOfEmployment = new DateTime(2000, 9, 1),
                                    HasPhd = true
                                }
                            }
                        }
                    }
                },
                new Student
                {
                    Name = "Kiss Mária",
                    NeptunCode = "PQR678",
                    BirthYear = 1999,
                    EnrollmentYear = 2018,
                    CompletedCredits = 90,
                    Absolved = false,
                    Graduated = false,
                    Subjects = new List<Subject>
                    {
                        new Subject
                        {
                            Credit = 6,
                            Name = "Szoftverfejlesztés alapjai",
                            Code = "SW101",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Dr. Varga László",
                                    NeptunCode = "UVW654",
                                    BirthYear = 1968,
                                    StartOfEmployment = new DateTime(1995, 4, 12),
                                    HasPhd = true
                                }
                            }
                        },
                        new Subject
                        {
                            Credit = 4,
                            Name = "Analízis II.",
                            Code = "ANAL102",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Dr. Farkas Béla",
                                    NeptunCode = "ABC321",
                                    BirthYear = 1972,
                                    StartOfEmployment = new DateTime(2001, 11, 1),
                                    HasPhd = true
                                }
                            }
                        },
                        new Subject
                        {
                            Credit = 5,
                            Name = "Adatbázisok",
                            Code = "DB102",
                            HasExam = true,
                            Teachers = new List<Teacher>
                            {
                                new Teacher
                                {
                                    Name = "Nagy Gábor",
                                    NeptunCode = "LMN456",
                                    BirthYear = 1980,
                                    StartOfEmployment = new DateTime(2005, 2, 15),
                                    HasPhd = false
                                }
                            }
                        }
                    }
                }
            };

            var q1 = students.Where(x => x.CompletedCredits == students.Max(x => x.CompletedCredits)).FirstOrDefault();
            Console.WriteLine($"1. Legtöbb credit:\n\t{q1.Name} - {q1.CompletedCredits}");

            var q2 = students.Where(x => x.BirthYear == students.Min(x => x.BirthYear)).FirstOrDefault();
            Console.WriteLine($"\n2. Legkorábban született:\n\t{q1.Name} - {q1.BirthYear}");

            var q3 = students.SelectMany(x => x.Subjects).SelectMany(x => x.Teachers).OrderBy(x => x.StartOfEmployment).FirstOrDefault();
            Console.WriteLine($"\n3. Melyik tanár kezdte legkorábban?\n\t{q3.Name} - {q3.StartOfEmployment}");

            var q4 = students.OrderByDescending(x => x.Subjects.Count(y => y.Teachers.Any(z => z.Name == "Dr. Varga László"))).FirstOrDefault();
            Console.WriteLine($"\n4. Melyik hallgató rendelkezik a legtöbb tantárggyal, amelyeket Dr. Varga László tanít?\n\t{q4.Name}");

            var q5 = students.Count(x=> x.Absolved==true && x.Graduated==false);
            Console.WriteLine($"\n5. Hány hallgató abszolválta már az összes tárgyát, de még nem diplomázott?\n\t{q5}");

            var q6 = students.SelectMany(x => x.Subjects)
                .GroupBy(x => x.Code)
                .OrderByDescending(x => x.SelectMany(y => y.Teachers).Distinct().Count())
                .Select(x=>x.FirstOrDefault()).FirstOrDefault();
            Console.WriteLine($"\n6. Melyik tantárgy rendelkezik a legtöbb tanárral?\n\t{q6.Name}");

            var q7 = students.Count(x => x.EnrollmentYear >= 2018);
            Console.WriteLine($"\n7. Hány hallgató van, akik 2018-ban vagy később iratkoztak be?\n\t{q7}");

            var q8 = students.OrderByDescending(x => x.Subjects.Count(y => y.HasExam == true)).FirstOrDefault();
            Console.WriteLine($"\n8. Melyik hallgató rendelkezik a legtöbb olyan tantárggyal, amelyekhez tartozik vizsga?\n\t{q8.Name}");

            //var q9;

            var q10 = students.GroupBy(x => x.BirthYear).OrderByDescending(x => x.Count()).Select(x=>x.Key).FirstOrDefault();
            Console.WriteLine($"\n10. Melyik évben született a legtöbb hallgató?\n\t{q10}");

            //var q11 = students.Where(x=>x.Graduated==true).SelectMany

            var q12 = students.Count(x => x.CompletedCredits > 200);
            Console.WriteLine($"\n12. Hány hallgató van, aki több mint 200 kreditet szerzett?\n\t{q12}");

            var q13 = students.OrderByDescending(x => x.Subjects.Count(y => y.Teachers.Count() == 1)).FirstOrDefault();
            Console.WriteLine($"\n13. Melyik hallgató rendelkezik a legtöbb olyan tantárggyal, amelyeket egyetlen tanár tanít?\n\t{q13.Name}");

            var q14 = students.Count(x => x.Absolved = false);
            Console.WriteLine($"\n14. Hány hallgató van, aki még nem abszolválta az összes tantárgyát?\n\t{q14}");

            var q15 = students.SelectMany(x => x.Subjects.OrderByDescending(y => y.Teachers.Count(z => z.HasPhd == false))).FirstOrDefault();
            Console.WriteLine($"\n15. Melyik tantárgyat tanítják a legtöbben olyan tanárok, akiknek nincs PhD fokozatuk?\n\t{q15.Name}");

            var q16 = students.Where(x => x.CompletedCredits == students.Min(x => x.CompletedCredits)).FirstOrDefault();
            Console.WriteLine($"\n16. Melyik hallgató rendelkezik a legkevesebb kredittel?\n\t{q16.Name}");

            var q17 = students.Count(x => x.CompletedCredits == 180);
            Console.WriteLine($"\n17. Hány hallgató rendelkezik pontosan 180 kredittel?\n\t{q17}");

            var q18 = students.Where(x => x.Subjects.Any(x => x.Name == "Adatbázisok"));
            Console.WriteLine($"\n18. Melyik hallgató tanulja az \"Adatbázisok\" tantárgyat?");
            foreach (var item in q18)
            {
                Console.WriteLine($"\t-{item.Name}");
            }

            var q19 = students.SelectMany(x=>x.Subjects.OrderByDescending(y=>y.Teachers.Min(z=>z.BirthYear))).FirstOrDefault();
            Console.WriteLine($"\n19. Melyik tantárgy tanárai között található a legfiatalabb tanár?\n\t{q19.Name}");

            var q20 = students.Count(x=>x.Subjects.Count()==2);
            Console.WriteLine($"\n20. Hány hallgató van, aki pontosan két tantárgyat tanul?\n\t{q20}");
        }
    }
}
