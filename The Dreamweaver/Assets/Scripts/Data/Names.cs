using System.Collections.Generic;

public class Names
{
    public class CountryNames
    {

        public List<string> GetNamesForCountry(string country, int gender)
        {
            switch (country)
            {
                case "USA":
                    return GetUSANames(gender);
                case "Canada":
                    return GetCanadaNames(gender);
                case "Germany":
                    return GetGermanyNames(gender);
                case "Sweden":
                    return GetSwedenNames(gender);
                case "Italy":
                    return GetItalyNames(gender);
                case "France":
                    return GetFranceNames(gender);
                case "Spain":
                    return GetSpainNames(gender);
                case "UK":
                    return GetUKNames(gender);
                case "Australia":
                    return GetAustraliaNames(gender);
                case "Brazil":
                    return GetBrazilNames(gender);
                case "Japan":
                    return GetJapanNames(gender);
                case "South Korea":
                    return GetSouthKoreaNames(gender);
                case "China":
                    return GetChinaNames(gender);
                case "India":
                    return GetIndiaNames(gender);
                case "Russia":
                    return GetRussiaNames(gender);
                case "Mexico":
                    return GetMexicoNames(gender);
                case "South Africa":
                    return GetSouthAfricaNames(gender);
                case "Argentina":
                    return GetArgentinaNames(gender);
                case "Egypt":
                    return GetEgyptNames(gender);
                case "Nigeria":
                    return GetNigeriaNames(gender);
                case "Turkey":
                    return GetTurkeyNames(gender);
                default:
                    return new List<string>(); // If country is not in the list, return empty list
            }
        }

        public List<string> GetLastNamesForCountry(string country, int gender)
        {
            switch (country)
            {
                case "USA":
                    return GetUSALastNames();
                case "Canada":
                    return GetCanadaLastNames();
                case "Germany":
                    return GetGermanyLastNames();
                case "Sweden":
                    return GetSwedenLastNames();
                case "Italy":
                    return GetItalyLastNames();
                case "France":
                    return GetFranceLastNames();
                case "Spain":
                    return GetSpainLastNames(gender);
                case "UK":
                    return GetUKLastNames();
                case "Australia":
                    return GetAustraliaLastNames();
                case "Brazil":
                    return GetBrazilLastNames();
                case "Japan":
                    return GetJapanLastNames();
                case "South Korea":
                    return GetSouthKoreaLastNames();
                case "China":
                    return GetChinaLastNames();
                case "India":
                    return GetIndiaLastNames();
                case "Russia":
                    return GetRussiaLastNames(gender);
                case "Mexico":
                    return GetMexicoLastNames();
                case "South Africa":
                    return GetSouthAfricaLastNames();
                case "Argentina":
                    return GetArgentinaLastNames();
                case "Egypt":
                    return GetEgyptLastNames();
                case "Nigeria":
                    return GetNigeriaLastNames();
                case "Turkey":
                    return GetTurkeyLastNames();
                default:
                    return new List<string>(); // If country is not in the list, return an empty list
            }
        }

        // Helper methods for each country:

        // USA
        public List<string> GetUSANames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "James", "John", "Robert", "Michael", "William",
                    "David", "Richard", "Joseph", "Charles", "Thomas",
                    "Christopher", "Daniel", "Matthew", "Anthony", "Mark",
                    "Donald", "Steven", "Paul", "Andrew", "Joshua",
                    "Kenneth", "Kevin", "Brian", "George", "Edward",
                    "Ronald", "Timothy", "Jason", "Jeffrey", "Ryan",
                    "Jacob", "Gary", "Nicholas", "Eric", "Jonathan",
                    "Stephen", "Larry", "Justin", "Scott", "Brandon",
                    "Benjamin", "Samuel", "Gregory", "Frank", "Alexander",
                    "Raymond", "Patrick", "Jack", "Dennis", "Jerry"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Mary", "Patricia", "Jennifer", "Linda", "Elizabeth",
                    "Barbara", "Susan", "Jessica", "Sarah", "Karen",
                    "Nancy", "Betty", "Helen", "Dorothy", "Sandra",
                    "Margaret", "Ashley", "Kimberly", "Donna", "Carol",
                    "Ruth", "Sharon", "Michelle", "Laura", "Sarah",
                    "Kimberly", "Deborah", "Helen", "Lisa", "Angela",
                    "Shirley", "Debra", "Betty", "Dorothy", "Amanda",
                    "Melissa", "Sophia", "Charlotte", "Evelyn", "Cheryl",
                    "Virginia", "Julie", "Joyce", "Megan", "Hannah",
                    "Katherine", "Maria", "Amy", "Tammy", "Lisa"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // Canada
        public List<string> GetCanadaNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Liam", "Noah", "Jackson", "Lucas", "Logan",
                    "Ethan", "James", "Benjamin", "Alexander", "William",
                    "Oliver", "Daniel", "Henry", "Sebastian", "Matthew",
                    "Jack", "Samuel", "David", "Joseph", "Maximus",
                    "Gabriel", "Charlie", "Ryan", "Luke", "Jack",
                    "Zachary", "Michael", "Nathan", "Jacob", "Aiden",
                    "Isaac", "Mason", "Andrew", "Isaiah", "Carter",
                    "Elijah", "Luca", "Xander", "Dylan", "Austin",
                    "Adam", "Tyler", "Owen", "Matthew", "Alexander",
                    "Samuel", "Christopher", "Jackson", "Robert", "Oliver"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Emma", "Olivia", "Charlotte", "Amelia", "Avery",
                    "Sophia", "Mia", "Isabella", "Abigail", "Evelyn",
                    "Emily", "Harper", "Lily", "Chloe", "Madison",
                    "Ella", "Grace", "Victoria", "Zoe", "Riley",
                    "Ariana", "Nora", "Addison", "Hannah", "Eleanor",
                    "Aria", "Scarlett", "Lillian", "Natalie", "Aubrey",
                    "Hazel", "Brooklyn", "Aurora", "Violet", "Claire",
                    "Bella", "Sophie", "Emily", "Cora", "Lucy",
                    "Sadie", "Stella", "Mila", "Riley", "Maya",
                    "Madeline", "Luna", "Eleanor", "Paisley", "Ava"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // Germany
        public List<string> GetGermanyNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Lukas", "Leon", "Paul", "Jonas", "Noah",
                    "Finn", "Luis", "Emil", "Elias", "Felix",
                    "Maximilian", "David", "Jakob", "Tobias", "Moritz",
                    "Niklas", "Tim", "Alexander", "Samuel", "Jan",
                    "Johannes", "Max", "Benjamin", "Henrik", "Simon",
                    "Oscar", "Lennard", "Mats", "Fabian", "Benedikt",
                    "Florian", "Jakob", "Stefan", "Adrian", "Fabian",
                    "Johann", "Christian", "Andreas", "Michael", "Daniel",
                    "Markus", "Sebastian", "Mark", "Peter", "Thomas",
                    "Timo", "Rafael", "Martin", "Gregor", "Sebastian"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Mia", "Emma", "Hannah", "Sophia", "Anna",
                    "Lea", "Lina", "Emilia", "Lina", "Lena",
                    "Marie", "Clara", "Maja", "Johanna", "Charlotte",
                    "Luisa", "Amelie", "Lena", "Sarah", "Sophie",
                    "Eva", "Julia", "Lisa", "Laura", "Lara",
                    "Alina", "Paula", "Nina", "Klara", "Miriam",
                    "Antonia", "Isabel", "Elena", "Carla", "Franziska",
                    "Elisabeth", "Victoria", "Leonie", "Mira", "Katrin",
                    "Gina", "Jana", "Sarah", "Rebecca", "Greta",
                    "Sabrina", "Tabea", "Katharina", "Nadine", "Veronika"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        public List<string> GetSwedenNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Erik", "Karl", "Lars", "Anders", "Johan",
                    "Henrik", "Niklas", "Mikael", "Peter", "Magnus",
                    "Oskar", "Daniel", "Kristian", "Jonas", "David",
                    "Patrik", "Alexander", "Fredrik", "Andreas", "Mattias",
                    "Thomas", "Emil", "Samuel", "Viktor", "Benjamin",
                    "Gustav", "Simon", "Arvid", "Ludvig", "Albin",
                    "Axel", "William", "Max", "Sebastian", "Isak",
                    "Oliver", "Nils", "Felix", "Elvis", "Martin",
                    "Rasmus", "Tim", "Oscar", "Jonathan", "Oliver",
                    "Sven", "David", "Leon", "Lukas", "Theo"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Anna", "Eva", "Maria", "Kristina", "Margareta",
                    "Karin", "Monica", "Ulla", "Lena", "Sofia",
                    "Elisabeth", "Charlotte", "Cecilia", "Sara", "Camilla",
                    "Emma", "Jenny", "Birgitta", "Ingrid", "Frida",
                    "Linnea", "Alice", "Hanna", "Rebecca", "Julia",
                    "Maja", "Sally", "Ella", "Tove", "Alma",
                    "Lovisa", "Signe", "Ida", "Ellen", "Olivia",
                    "Tilda", "Isabelle", "Sofia", "Victoria", "Fanny",
                    "Ebba", "Ebba", "Matilda", "Selma", "Carolina",
                    "Nora", "Stella", "Miriam", "Livia", "Alicia"
                };
            }
            else
            {
                // Return an empty list or handle invalid gender input
                return new List<string>();
            }
        }

        // Spain
        public List<string> GetSpainNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Antonio", "Manuel", "José", "Francisco", "David",
                    "Juan", "Pedro", "Ángel", "José Luis", "Carlos",
                    "Javier", "Daniel", "Miguel Ángel", "Rafael", "Fernando",
                    "Álvaro", "Sergio", "Luis", "Pablo", "Ricardo",
                    "Andrés", "Mario", "Ramón", "Víctor", "Martín",
                    "Pedro", "Jesús", "Emilio", "Guillermo", "Julio",
                    "Adrián", "Félix", "Ignacio", "Álex", "César",
                    "Salvador", "Eduardo", "Jaime", "Samuel", "Jorge",
                    "Héctor", "Iker", "Rubén", "Oscar", "Arturo"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "María", "Carmen", "Josefa", "Ana", "Laura",
                    "Isabel", "Marta", "Paula", "Dolores", "Elena",
                    "Raquel", "Beatriz", "Pilar", "Antonia", "Teresa",
                    "Cristina", "Carolina", "Sandra", "Gloria", "Verónica",
                    "Patricia", "Susana", "Julia", "Vanessa", "Victoria",
                    "Alba", "Irene", "Silvia", "Noelia", "María José",
                    "Montserrat", "Alicia", "Begoña", "Lorena", "Mercedes",
                    "Sofía", "Lourdes", "Celia", "Esther", "Lidia",
                    "Nerea", "Inmaculada", "Adela", "Rocío", "Marina"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // UK
        public List<string> GetUKNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "James", "John", "Robert", "Michael", "David",
                    "William", "Richard", "Joseph", "Charles", "Thomas",
                    "Christopher", "Daniel", "Matthew", "Anthony", "Mark",
                    "Steven", "Paul", "Andrew", "Joshua", "Kenneth",
                    "Kevin", "Brian", "George", "Edward", "Ronald",
                    "Timothy", "Jason", "Jeffrey", "Ryan", "Jacob",
                    "Gary", "Nicholas", "Eric", "Jonathan", "Stephen",
                    "Larry", "Justin", "Scott", "Brandon", "Benjamin",
                    "Samuel", "Gregory", "Frank", "Alexander", "Raymond",
                    "Patrick", "Jack", "Dennis", "Jerry", "Thomas"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Mary", "Patricia", "Jennifer", "Linda", "Elizabeth",
                    "Barbara", "Susan", "Jessica", "Sarah", "Karen",
                    "Nancy", "Betty", "Helen", "Dorothy", "Sandra",
                    "Margaret", "Ashley", "Kimberly", "Donna", "Carol",
                    "Ruth", "Sharon", "Michelle", "Laura", "Sarah",
                    "Kimberly", "Deborah", "Helen", "Lisa", "Angela",
                    "Shirley", "Debra", "Betty", "Dorothy", "Amanda",
                    "Melissa", "Sophia", "Charlotte", "Evelyn", "Cheryl",
                    "Virginia", "Julie", "Joyce", "Megan", "Hannah",
                    "Katherine", "Maria", "Amy", "Tammy", "Lisa"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // Australia
        public List<string> GetAustraliaNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Jack", "Oliver", "William", "Noah", "James",
                    "Leo", "Charlie", "Lucas", "Mason", "Ethan",
                    "Henry", "Jacob", "Liam", "Alexander", "Max",
                    "Isaac", "Samuel", "Thomas", "Benjamin", "Zachary",
                    "Daniel", "Ryan", "Jayden", "Cooper", "Matthew",
                    "Joshua", "Elijah", "Nathan", "Oscar", "David",
                    "Sebastian", "Dylan", "Xavier", "George", "Cooper",
                    "Oliver", "Harrison", "Jaxon", "Luca", "Owen",
                    "Tyler", "Cameron", "Lachlan", "Isaiah", "Myles"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Olivia", "Charlotte", "Amelia", "Ava", "Emily",
                    "Isla", "Grace", "Mia", "Ella", "Harper",
                    "Chloe", "Sophie", "Lily", "Sophia", "Abigail",
                    "Ruby", "Zoe", "Scarlett", "Hannah", "Aria",
                    "Ariana", "Victoria", "Lucy", "Alice", "Evelyn",
                    "Lila", "Isabel", "Leah", "Sienna", "Madeline",
                    "Maya", "Clara", "Mackenzie", "Paige", "Mackenzie",
                    "Sarah", "Bella", "Amelie", "Sophie", "Stella",
                    "Holly", "Lily", "Megan", "Eden", "Poppy"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // Brazil
        public List<string> GetBrazilNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Miguel", "Arthur", "Heitor", "Bernardo", "Gabriel",
                    "Lucas", "Davi", "Pedro", "Rafael", "Gustavo",
                    "Felipe", "Vitor", "Matheus", "Enzo", "Samuel",
                    "Henrique", "João", "José", "Theo", "Leonardo",
                    "Daniel", "Caio", "Thiago", "Vinícius", "Lucas",
                    "Eduardo", "Lucas", "Raul", "Fábio", "Iago",
                    "Augusto", "Joaquim", "Alexandre", "Igor", "Murilo",
                    "Cauã", "Luan", "Diego", "Guilherme", "Isaac",
                    "Tomas", "Antonio", "Marcos", "Luan", "Nicolas"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Maria", "Ana", "Beatriz", "Alice", "Juliana",
                    "Gabriela", "Fernanda", "Camila", "Luana", "Sofia",
                    "Larissa", "Isabela", "Carla", "Mariana", "Vitória",
                    "Giovanna", "Michele", "Raquel", "Júlia", "Luiza",
                    "Nicole", "Amanda", "Viviane", "Patrícia", "Clara",
                    "Laura", "Letícia", "Lúcia", "Roberta", "Manuela",
                    "Bruna", "Emanuelle", "Olivia", "Débora", "Renata",
                    "Cristiane", "Adriana", "Raissa", "Kelly", "Tainá",
                    "Simone", "Lilian", "Yasmin", "Aline", "Monique"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // Japan
        public List<string> GetJapanNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Haruto", "Yuto", "Sota", "Yuki", "Ren",
                    "Kaito", "Riku", "Kohaku", "Ryusei", "Kenta",
                    "Daiki", "Shunya", "Shota", "Hinata", "Ryo",
                    "Kei", "Yuma", "Kouki", "Seiya", "Haruki",
                    "Sho", "Naoki", "Takumi", "Ryuto", "Sakura",
                    "Hiroto", "Shin", "Tsubasa", "Keito", "Jin",
                    "Yuya", "Taiga", "Issei", "Satoru", "Hikaru",
                    "Rei", "Takuto", "Tatsuya", "Yuji", "Makoto",
                    "Koki", "Daigo", "Kosei", "Yu", "Aoi"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Sakura", "Yui", "Haruka", "Miku", "Aoi",
                    "Riko", "Hinata", "Akari", "Miyu", "Nana",
                    "Yuna", "Natsuki", "Kana", "Rina", "Yuina",
                    "Aika", "Saki", "Moe", "Miyuki", "Noa",
                    "Mei", "Yuka", "Ayaka", "Sayaka", "Rika",
                    "Nanami", "Reina", "Yuika", "Misa", "Mayu",
                    "Sumire", "Kanna", "Emi", "Yurina", "Mai",
                    "Kaori", "Chihiro", "Rie", "Yukari", "Riko",
                    "Ami", "Miku", "Hina", "Nanami", "Ayumi"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // South Korea
        public List<string> GetSouthKoreaNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Jin", "Jimin", "Jungkook", "Suga", "V",
                    "Rap Monster", "Hoseok", "Seokjin", "Jinwoo", "Sangho",
                    "Jungwoo", "Minho", "Kangmin", "Geunseok", "Eunwoo",
                    "Changmin", "Jiwon", "Donghae", "Jae", "Sungmin",
                    "Hyun", "Junho", "Jaehyun", "Taeyang", "Woojin",
                    "Minseok", "Jaemin", "Hoseok", "Kang", "Kyungsoo",
                    "Siwon", "Sangmin", "Jungjae", "Seungkwan", "Kyuhyun",
                    "Jongin", "Yeongho", "Seungri", "Changmin", "Seungjae",
                    "Namjoon", "Jiyeon", "Kihyun", "Youngbin", "Baekhyun"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Jisoo", "Jennie", "Lisa", "Rosé", "Soojin",
                    "Yuju", "Nayoung", "Somi", "Eunji", "Seungyeon",
                    "Jiwon", "Yeji", "Mijoo", "Yerin", "Soyeon",
                    "Mina", "Hyeri", "Jiwon", "Jihyo", "Sana",
                    "Chaeyoung", "Nayeon", "Tzuyu", "Momo", "Dahyun",
                    "Eunha", "Yewon", "Jiho", "Sunmi", "Hyojung",
                    "Seulgi", "Wendy", "Joy", "Irene", "Sujin",
                    "Sera", "Gugudan", "Miyoung", "Somin", "Yuna",
                    "Jiwon", "Chungha", "Soo", "Chaeyeon", "Eunjin"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // China
        public List<string> GetChinaNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Li", "Wang", "Zhang", "Liu", "Chen",
                    "Yang", "Huang", "Zhao", "Wu", "Xu",
                    "Sun", "Ma", "Zhou", "Wu", "Zheng",
                    "Liang", "Shen", "Guo", "Qian", "Tang",
                    "Deng", "Gao", "Song", "Xie", "Lu",
                    "Shen", "Liao", "Yu", "Dong", "Xue",
                    "Cai", "Li", "Shen", "Yang", "Qiu",
                    "Liu", "Cai", "Tao", "Fang", "Wei",
                    "Ren", "Zhou", "Jiang", "Zheng", "Wu"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Liu", "Wang", "Zhang", "Li", "Yang",
                    "Liang", "Zhao", "Chen", "Qiu", "Li",
                    "Fang", "Yin", "Zhou", "Xu", "Li",
                    "Li", "Deng", "Jiang", "Yuan", "Wang",
                    "Gao", "Zheng", "Cai", "Fang", "Liu",
                    "Lu", "Yu", "Yin", "Xie", "Shen",
                    "Yang", "Zhu", "Liao", "Wang", "Song",
                    "Huang", "Xue", "Ma", "Ren", "Tao",
                    "Shen", "Qian", "Zhang", "Shao", "Tan"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // India
        public List<string> GetIndiaNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Aarav", "Vivaan", "Aditya", "Vihaan", "Arjun",
                    "Sai", "Ishaan", "Krishna", "Aryan", "Raghav",
                    "Ayaan", "Reyansh", "Shaan", "Kabir", "Rohan",
                    "Dev", "Karthik", "Ansh", "Shivansh", "Dhruv",
                    "Yash", "Abhinav", "Manav", "Ayush", "Laksh",
                    "Aniket", "Parth", "Kunal", "Tanish", "Ojas",
                    "Tanay", "Rishi", "Harsh", "Avi", "Nikhil",
                    "Pranav", "Raj", "Udit", "Tejas", "Siddharth",
                    "Krish", "Vishal", "Alok", "Rajiv", "Saurabh"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Aadhya", "Saanvi", "Ishita", "Aanya", "Ananya",
                    "Diya", "Kavya", "Riya", "Sanya", "Shruti",
                    "Swara", "Madhuri", "Pooja", "Neha", "Tanvi",
                    "Tanya", "Simran", "Priya", "Nisha", "Nikita",
                    "Radhika", "Kriti", "Divya", "Meera", "Chhavi",
                    "Rhea", "Sonali", "Aditi", "Alisha", "Shrishti",
                    "Sushmita", "Sanya", "Sonakshi", "Kanika", "Komal",
                    "Neelam", "Suman", "Vidhi", "Vanshika", "Barkha",
                    "Madhavi", "Siddhi", "Kanak", "Bhuvana", "Manisha"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // Russia
        public List<string> GetRussiaNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Ivan", "Alexei", "Dmitry", "Sergey", "Andrei",
                    "Maxim", "Nikolai", "Vladimir", "Pavel", "Konstantin",
                    "Mikhail", "Yuri", "Oleg", "Viktor", "Roman",
                    "Daniil", "Igor", "Boris", "Kirill", "Vadim",
                    "Artem", "Egor", "Leonid", "Vyacheslav", "Anatoly",
                    "Semyon", "Vassily", "Timur", "Denis", "Aleksei",
                    "Stepan", "Vsevolod", "Valery", "Gleb", "Petr",
                    "Alexandr", "Maksim", "Igor", "Nikita", "Fedor",
                    "Kirill", "Georgiy", "Gennady", "Ruslan", "Maksym"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Anastasia", "Daria", "Maria", "Elena", "Olga",
                    "Natalia", "Tatiana", "Ekaterina", "Irina", "Victoria",
                    "Yulia", "Svetlana", "Nina", "Vera", "Ludmila",
                    "Alina", "Polina", "Valeria", "Galina", "Larisa",
                    "Ksenia", "Tatiana", "Oksana", "Vasilisa", "Nadezhda",
                    "Alyona", "Liza", "Yana", "Margarita", "Zinaida",
                    "Yekaterina", "Viktoria", "Inna", "Taisia", "Kira",
                    "Raisa", "Irina", "Elizaveta", "Zhanna", "Alla",
                    "Lilia", "Marina", "Rina", "Zoya", "Lina"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // Mexico
        public List<string> GetMexicoNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Carlos", "José", "Juan", "Miguel", "Luis",
                    "Javier", "Ricardo", "Francisco", "Antonio", "Manuel",
                    "Fernando", "Pedro", "Eduardo", "David", "Raul",
                    "Gabriel", "Hernan", "Ramon", "Victor", "Santiago",
                    "Alejandro", "Mario", "Diego", "Oscar", "Daniel",
                    "Adrian", "Emilio", "Marco", "Julian", "Emiliano",
                    "Juan Carlos", "Salvador", "Felipe", "Armando", "Andres",
                    "Hector", "Jorge", "Arturo", "Julio", "Ricardo",
                    "Sergio", "Luis Enrique", "Samuel", "Esteban", "Gustavo"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Maria", "Juana", "Laura", "Carmen", "Patricia",
                    "Ana", "Rosa", "Isabel", "Josefa", "Dolores",
                    "Elena", "Teresa", "Margarita", "Luisa", "Victoria",
                    "Sandra", "Beatriz", "Raquel", "Monica", "Veronica",
                    "Jessica", "Sofia", "Andrea", "Adriana", "Carolina",
                    "Lorena", "Paola", "Vera", "Francisca", "Natalia",
                    "Cristina", "Gabriela", "Celia", "Mariana", "Berta",
                    "Isela", "Noemi", "Lilia", "Alma", "Emilia",
                    "Rocío", "Vanessa", "Leticia", "Alicia", "Catalina"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // South Africa
        public List<string> GetSouthAfricaNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Liam", "Noah", "Ethan", "Micha", "Lucas",
                    "Levi", "Matthew", "James", "Daniel", "Benjamin",
                    "Oliver", "Samuel", "Alexander", "Jackson", "Aiden",
                    "Elijah", "David", "Isaac", "William", "Leo",
                    "Henry", "Nathan", "Max", "Theo", "Sebastian",
                    "Gabriel", "Zachary", "Tyler", "Caleb", "Jacob",
                    "Owen", "Jacob", "Jordan", "Nicholas", "Adam",
                    "Reuben", "Matthew", "Jaden", "Charles", "Adam"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Amara", "Ava", "Ella", "Emily", "Chloe",
                    "Isabella", "Olivia", "Mia", "Harper", "Zoe",
                    "Sophia", "Charlotte", "Lily", "Layla", "Madeline",
                    "Leah", "Victoria", "Eva", "Sophia", "Sarah",
                    "Ellie", "Stella", "Emma", "Ariana", "Lucy",
                    "Grace", "Luna", "Ruby", "Zoey", "Aria",
                    "Audrey", "Alice", "Megan", "Scarlett", "Lilly",
                    "Hazel", "Penelope", "Autumn", "Clara", "Audrey",
                    "Brooklyn", "Eliza", "Madison", "Josephine", "Gianna"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // Argentina
        public List<string> GetArgentinaNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Santiago", "Benjamín", "Thiago", "Facundo", "Matías",
                    "Agustín", "Lucas", "Felipe", "Juan", "Tomás",
                    "Martín", "Pedro", "Manuel", "José", "Ezequiel",
                    "Emiliano", "Diego", "Joaquín", "Nicolás", "Gabriel",
                    "Maximiliano", "Carlos", "Fernando", "David", "Miguel",
                    "Ricardo", "Raúl", "Diego", "Hernán", "Julian",
                    "Ramón", "Oscar", "Alejandro", "Iván", "Adrián",
                    "Ángel", "Héctor", "Juan Carlos", "Rafael", "Sergio",
                    "Juan Manuel", "Ariel", "Leandro", "Andrés", "César"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Sofía", "Valentina", "Mia", "Lucía", "Martina",
                    "Renata", "Emma", "Catalina", "Isabella", "Florencia",
                    "Julieta", "Ana", "Violeta", "Luz", "Camila",
                    "Ana Clara", "Juliana", "Gabriela", "Agustina", "Margarita",
                    "Jimena", "Carolina", "Romina", "Andrea", "Mariana",
                    "Paula", "Lía", "Celeste", "Cecilia", "Victoria",
                    "Ángeles", "Liliana", "Alma", "Carla", "Paola",
                    "Rocío", "Diana", "Verónica", "Silvina", "Clara",
                    "Elena", "Liliana", "Fabiola", "Eugenia", "Beatriz"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // Egypt
        public List<string> GetEgyptNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Ahmed", "Mohamed", "Ali", "Omar", "Mostafa",
                    "Tamer", "Khaled", "Hassan", "Ibrahim", "Sami",
                    "Hussein", "Mahmoud", "Amr", "Maher", "Youssef",
                    "Gamal", "Kamal", "Ayman", "Sherif", "Fayez",
                    "Hany", "Ramy", "Nader", "Mohsen", "Waleed",
                    "Ehab", "Ashraf", "Mansour", "Fouad", "Alaa",
                    "Samir", "Tariq", "Hossam", "Mouhamed", "Saad",
                    "Zakaria", "Sherif", "Yasser", "Gaber", "Fathi",
                    "Marwan", "Khalil", "Wael", "Hassan", "Osama"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Fatma", "Mona", "Sara", "Amira", "Heba",
                    "Dalia", "Rania", "Nahla", "Mariam", "Nadia",
                    "Rasha", "Nada", "Yasmin", "Aya", "Salma",
                    "Amina", "Farah", "Layla", "Samia", "Riham",
                    "Khadija", "Reem", "Hanan", "Jasmine", "Huda",
                    "Eman", "Shahira", "Lina", "Zahra", "Dina",
                    "Sana", "Mariam", "Samar", "Rola", "Basma",
                    "Wafa", "Noha", "Salwa", "Mona", "Samira",
                    "Zeinab", "Hend", "Kholoud", "Maya", "Shaimaa"
                };
            }
            else
            {
                return new List<string>();
            }
        }
        // Nigeria
        public List<string> GetNigeriaNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Chijioke", "David", "John", "Michael", "Samuel",
                    "James", "Joshua", "Emeka", "Umar", "Ibrahim",
                    "Tunde", "Adamu", "Segun", "Nnamdi", "Akin",
                    "Joseph", "Abdul", "Ahmed", "Rashid", "Oluwaseun",
                    "Chuka", "Olumide", "Benjamin", "Jibola", "Ayodele",
                    "Durojaiye", "Femi", "Seyi", "Olufemi", "Timothy",
                    "Akintoye", "Ifeanyi", "Durojaiye", "Bolu", "Bamidele",
                    "Shola", "Chuka", "Tolu", "Olumide", "Olamide",
                    "Kayode", "Tosin", "Adeyemi", "Lekan", "Tobi"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Ngozi", "Chidinma", "Amara", "Ngozi", "Zainab",
                    "Mariam", "Amina", "Oluchi", "Rukayat", "Ifunanya",
                    "Emmanuella", "Ifeoma", "Aisha", "Halima", "Ireti",
                    "Titi", "Kemi", "Bola", "Folake", "Ada",
                    "Olamide", "Toluwani", "Durojaiye", "Funke", "Temidayo",
                    "Moji", "Ruth", "Oluwatobiloba", "Zainab", "Adebisi",
                    "Abimbola", "Sade", "Opeyemi", "Temiloluwa", "Nnena",
                    "Titilayo", "Oluwaseyi", "Oluwadamilola", "Kehinde", "Ayotunde"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // Turkey
        public List<string> GetTurkeyNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Ahmet", "Mehmet", "Mustafa", "Ali", "Hüseyin",
                    "İbrahim", "Osman", "Kadir", "Murat", "Emre",
                    "Yusuf", "Ramazan", "Salih", "Ferhat", "Okan",
                    "Deniz", "Baran", "Burak", "Kemal", "Cengiz",
                    "Serkan", "Sefa", "Turan", "Erkan", "Umut",
                    "Orhan", "Süleyman", "Recep", "Hakan", "Gökhan",
                    "Serhat", "Kaan", "Yavuz", "Furkan", "Onur",
                    "Yasin", "Berk", "Enes", "Barış", "Cem",
                    "Can", "Burhan", "Fatih", "Rıza", "Talha"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Fatma", "Emine", "Zeynep", "Elif", "Ayşe",
                    "Hatice", "Meryem", "Rabia", "İrem", "Şeyma",
                    "Cemre", "Havva", "Asya", "Büşra", "Merve",
                    "Duru", "Selin", "Seda", "Beyza", "Alara",
                    "Nazlı", "Sibel", "Aylin", "Vildan", "Dilara",
                    "Cansu", "Gizem", "Berrin", "Neslihan", "Aysel",
                    "Lale", "Fadime", "Serap", "Nur", "Alya",
                    "Gül", "Tuba", "Zehra", "Meyra", "Oya",
                    "Melek", "Sultan", "Büşra", "Şule", "Ayla"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // Italy
        public List<string> GetItalyNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Giuseppe", "Luca", "Matteo", "Andrea", "Francesco",
                    "Alessandro", "Marco", "Antonio", "Stefano", "Davide",
                    "Roberto", "Gabriele", "Paolo", "Vincenzo", "Nicola",
                    "Fabio", "Enrico", "Daniele", "Simone", "Giovanni",
                    "Luigi", "Pietro", "Carlo", "Salvatore", "Massimo",
                    "Emanuele", "Diego", "Claudio", "Sebastiano", "Riccardo",
                    "Michele", "Tommaso", "Alberto", "Raffaele", "Leonardo",
                    "Francesco", "Carmine", "Giorgio", "Antonio", "Lorenzo",
                    "Domenico", "Stefano", "Sandro", "Vito", "Aldo"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Giulia", "Maria", "Sara", "Anna", "Francesca",
                    "Martina", "Elena", "Chiara", "Laura", "Silvia",
                    "Alessandra", "Paola", "Caterina", "Beatrice", "Lucia",
                    "Valentina", "Federica", "Teresa", "Roberta", "Simona",
                    "Claudia", "Elisabetta", "Irene", "Giorgia", "Sofia",
                    "Angelica", "Rita", "Vanessa", "Livia", "Patrizia",
                    "Carla", "Marta", "Marina", "Valeria", "Alba",
                    "Giada", "Michela", "Luciana", "Elisabetta", "Annalisa",
                    "Paola", "Carolina", "Tiziana", "Sabrina", "Franca"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        // France
        public List<string> GetFranceNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Pierre", "Jean", "Michel", "Louis", "Paul",
                    "Henri", "Claude", "Jacques", "André", "Robert",
                    "François", "Bernard", "Daniel", "Georges", "René",
                    "Marcel", "Luc", "Christian", "Bernard", "Yves",
                    "Gérard", "Philippe", "Jacques", "Alain", "Thierry",
                    "Dominique", "Maurice", "Charles", "Jacques", "Romain",
                    "Antoine", "Éric", "Vincent", "Patrick", "Laurent",
                    "Thierry", "Pascal", "David", "Jean-Paul", "Cédric",
                    "Sébastien", "Lionel", "Nicolas", "Christophe", "Gilles"
                };
            }
            else if (gender == 1) // Female
            {
                return new List<string>
                {
                    "Marie", "Sophie", "Claire", "Catherine", "Isabelle",
                    "Nathalie", "Brigitte", "Monique", "Hélène", "Anne",
                    "Julie", "Chantal", "Élise", "Aline", "Valérie",
                    "Caroline", "Laure", "Patricia", "Sylvie", "Véronique",
                    "Françoise", "Cécile", "Dominique", "Sandrine", "Geneviève",
                    "Christine", "Alice", "Madeleine", "Lucie", "Camille",
                    "Lucienne", "Gisèle", "Lise", "Martine", "Nadine",
                    "Mireille", "Odile", "Simone", "Violette", "Estelle",
                    "Sylviane", "Marianne", "Ruth", "Gabrielle", "Bernadette"
                };
            }
            else
            {
                return new List<string>();
            }
        }

        public List<string> GetUSALastNames()
        {
            return new List<string>
            {
                "Anderson", "Brown", "Clark", "Davis", "Evans",
                "Garcia", "Harris", "Johnson", "King", "Lee",
                "Martin", "Moore", "Nelson", "Parker", "Robinson",
                "Scott", "Smith", "Taylor", "Thomas", "Walker"
            };
        }

        public List<string> GetCanadaLastNames()
        {
            return new List<string>
            {
                "Campbell", "Carter", "Clark", "Davis", "Graham",
                "Harris", "Jackson", "Johnson", "King", "Lee",
                "Martin", "Miller", "Moore", "Robinson", "Scott",
                "Taylor", "Thomas", "Walker", "White", "Wilson"
            };
        }

        public List<string> GetGermanyLastNames()
        {
            return new List<string>
            {
                "Müller", "Schmidt", "Weber", "Wagner", "Becker",
                "Hoffmann", "Schäfer", "Zimmermann", "Braun", "Richter",
                "Klein", "Wolf", "Koch", "Meyer", "Lehmann",
                "Schulz", "Schneider", "Fuchs", "Hartmann", "Zimmer"
            };
        }
        public List<string> GetSwedenLastNames()
        {
            return new List<string>
            {
                "Andersson", "Johansson", "Karlsson", "Nilsson", "Eriksson",
                "Larsson", "Persson", "Svensson", "Gustafsson", "Olsson",
                "Lindberg", "Holm", "Bengtsson", "Lindström", "Jönsson",
                "Möller", "Dahlberg", "Sandberg", "Nordin", "Wikström"
            };
        }

        public List<string> GetItalyLastNames()
        {
            return new List<string>
            {
                "Rossi", "Russo", "Ferrari", "Esposito", "Bianchi",
                "Romano", "Colombo", "Ricci", "Marino", "Greco",
                "Bruno", "Costa", "Conti", "De Luca", "Mancini",
                "Rizzo", "Giordano", "D'Angelo", "Barbieri", "Perri"
            };
        }

        public List<string> GetFranceLastNames()
        {
            return new List<string>
            {
                "Dupont", "Durand", "Lefevre", "Moreau", "Lemoine",
                "Lambert", "Lefevre", "Martin", "Robert", "Leclerc",
                "Thomas", "Michel", "Bernard", "Richard", "Petit",
                "Rousseau", "Blanc", "Dubois", "Simon", "Gerard"
            };
        }

        public List<string> GetSpainLastNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "González", "Rodríguez", "Pérez", "Sánchez", "López",
                    "García", "Martínez", "Fernández", "Díaz", "Romero",
                    "Jiménez", "Torres", "Sánchez", "Ruiz", "Álvarez",
                    "Herrera", "Muñoz", "Mendoza", "Vázquez", "Castro"
                };
            }
            else // Female
            {
                return new List<string>
                {
                    "González", "Rodríguez", "Pérez", "Sánchez", "López",
                    "García", "Martínez", "Fernández", "Díaz", "Romero",
                    "Jiménez", "Torres", "Sánchez", "Ruiz", "Álvarez",
                    "Herrera", "Muñoz", "Mendoza", "Vázquez", "Castro"
                };
            }
        }


        public List<string> GetUKLastNames()
        {
            return new List<string>
            {
                "Smith", "Johnson", "Williams", "Brown", "Taylor",
                "Davies", "Wilson", "Evans", "Thomas", "Jackson",
                "White", "Harris", "Roberts", "Green", "Hall",
                "Wood", "Lewis", "Clarke", "Allen", "Walker"
            };
        }

        public List<string> GetAustraliaLastNames()
        {
            return new List<string>
            {
                "Smith", "Jones", "Taylor", "Brown", "Wilson",
                "Johnson", "Davis", "Martin", "Lee", "Harris",
                "Clark", "Mitchell", "Robinson", "Walker", "Thompson",
                "Turner", "Young", "Anderson", "Scott", "Evans"
            };
        }

        public List<string> GetBrazilLastNames()
        {
            return new List<string>
            {
                "Silva", "Santos", "Oliveira", "Souza", "Pereira",
                "Costa", "Rodrigues", "Almeida", "Lima", "Carvalho",
                "Rocha", "Gomes", "Martins", "Fernandes", "Ribeiro",
                "Barbosa", "Araujo", "Pires", "Vieira", "Melo"
            };
        }

        public List<string> GetJapanLastNames()
        {
            return new List<string>
            {
                "Sato", "Suzuki", "Takahashi", "Tanaka", "Watanabe",
                "Ito", "Yamamoto", "Nakamura", "Kobayashi", "Kato",
                "Yoshida", "Yamada", "Sasaki", "Yamaguchi", "Nakajima",
                "Fujita", "Matsumoto", "Murakami", "Inoue", "Ishikawa"
            };
        }

        public List<string> GetSouthKoreaLastNames()
        {
            return new List<string>
            {
                "Kim", "Lee", "Park", "Jeong", "Choi",
                "Cho", "Kang", "Yoon", "Im", "Jang",
                "Han", "Shin", "Song", "Hwang", "Oh",
                "Kwon", "Ahn", "Yoo", "Ryu", "Kim"
            };
        }

        public List<string> GetChinaLastNames()
        {
            return new List<string>
            {
                "Wang", "Li", "Zhang", "Liu", "Chen",
                "Yang", "Huang", "Zhao", "Wu", "Xu",
                "Sun", "Ma", "Zhou", "Hu", "Guo",
                "He", "Lin", "Luo", "Zheng", "Tang"
            };
        }

        public List<string> GetIndiaLastNames()
        {
            return new List<string>
            {
                "Patel", "Sharma", "Gupta", "Singh", "Kumar",
                "Reddy", "Joshi", "Mehta", "Rao", "Iyer",
                "Desai", "Agarwal", "Bhat", "Khanna", "Verma",
                "Jain", "Saxena", "Choudhury", "Malhotra", "Kaur"
            };
        }

        public List<string> GetMexicoLastNames()
        {
            return new List<string>
            {
                "González", "Hernández", "García", "Martínez", "López",
                "Pérez", "Sánchez", "Rodríguez", "Torres", "Ramírez",
                "Flores", "Díaz", "Gómez", "Ruiz", "Mendoza",
                "García", "Vázquez", "Castro", "Herrera", "Chávez"
            };
        }

        public List<string> GetSouthAfricaLastNames()
        {
            return new List<string>
            {
                "Botha", "de Villiers", "Van der Merwe", "Pretorius", "Meyer",
                "Jacobs", "Kruger", "Nel", "Prinsloo", "Oosthuysen",
                "van Wyk", "Smit", "Coetzee", "Barnard", "Steyn",
                "du Plessis", "Groenewald", "van Zyl", "Ferreira", "Roos"
            };
        }

        public List<string> GetArgentinaLastNames()
        {
            return new List<string>
            {
                "González", "Rodríguez", "Pérez", "López", "García",
                "Martínez", "Fernández", "Díaz", "Sánchez", "Romero",
                "Torres", "Morales", "Herrera", "López", "García",
                "Sánchez", "Rodríguez", "Ruiz", "Álvarez", "Castro"
            };
        }


        public List<string> GetRussiaLastNames(int gender)
        {
            if (gender == 0) // Male
            {
                return new List<string>
                {
                    "Ivanov", "Petrov", "Sidorov", "Mikhailov", "Fedorov",
                    "Alexandrov", "Orlov", "Smirnov", "Popov", "Kozlov",
                    "Novikov", "Pavlov", "Vasiliev", "Dmitriev", "Nikitin",
                    "Lebedev", "Volkov", "Morozov", "Gusev", "Karpov"
                };
            }
            else // Female
            {
                return new List<string>
                {
                    "Ivanova", "Petrova", "Sidorova", "Mikhailova", "Fedorova",
                    "Alexandrova", "Orlova", "Smirnova", "Popova", "Kozlova",
                    "Novikova", "Pavlova", "Vasilieva", "Dmitrieva", "Nikitina",
                    "Lebedeva", "Volkova", "Morozova", "Guseva", "Karpova"
                };
            }
        }

        public static List<string> GetEgyptLastNames()
        {
            return new List<string>
            {
                "Ahmed", "Mohamed", "Ali", "Hassan", "Abdallah",
                "Fahmy", "Said", "El-Sayed", "Kamal", "Rashid",
                "Zaki", "Farouk", "Youssef", "Mansour", "Khalil",
                "Basyuni", "Hussein", "Gamal", "Abdelaziz", "Shams",
                "Taha"
            };
        }

        public static List<string> GetNigeriaLastNames()
        {
            return new List<string>
            {
                "Adebayo", "Adekunle", "Afolabi", "Ajayi", "Alabi",
                "Chukwu", "Durojaiye", "Eze", "Ibrahim", "Idris",
                "Ogunleye", "Okafor", "Oluwaseun", "Olamide", "Ogunyemi",
                "Salami", "Suleiman", "Tunde", "Yakubu", "Yusuf"
            };
        }

        public static List<string> GetTurkeyLastNames()
        {
            return new List<string>
            {
                "Yılmaz", "Kaya", "Demir", "Çelik", "Arslan",
                "Şahin", "Öztürk", "Kılıç", "Aydın", "Büyük",
                "Güzel", "Özdemir", "Karaca", "Doğan", "Yıldız",
                "Türk", "Koç", "Çetin", "Güler", "Balcı"
            };
        }
    }
}
