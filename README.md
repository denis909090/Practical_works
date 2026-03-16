Переніс код із одного файлу на модульну структуру
- `main.cs` — точка входу, тільки виклики методів
- `base_tasks.cs` — базові завдання (task_1 — task_5)
- `first_individual_tasks.cs` — індивідуальні завдання (task_1 — task_7)
- `trainee_file` – для особистих спроб програмування

Всі дії з git виконую в консолі VSCode

Структура побудови всих проектів


Репозиторій Practical_works
└─ 📄 main.cs
        └─ class Project
            └─ Main()
└─ trainee_file.cs

└─ 📁 practical_1
    └─ 📄 base_tasks.cs
        └─ namespace Project.pract_1
            └─ class base_tasks
                ├─ public static void task_1()
                ├─ public static void task_2()
                └─ public static void task_3()
    └─ 📄 individual_tasks.cs
        └─ namespace Project.pract_1
            └─ class individual_tasks
                ├─ public static void task_1()
                ├─ public static void task_2()

└─ 📁 practical_2
    └─ 📄 base_tasks.cs
        └─ namespace Project.pract_2
            └─ class base_tasks
                ├─ public static void task_1()
                ├─ public static void task_2()
                └─ public static void task_3()
    └─ 📄 individual_tasks.cs
        └─ namespace Project.pract_2
            └─ class individual_tasks
                ├─ public static void task_1()
                ├─ public static void task_2()

📁 practical_2
    └─ 📄 base_tasks.cs
        └─ namespace Project.pract_2
            └─ class base_tasks
                ├─ public static void task_1()
                ├─ public static void task_2()
                └─ public static void task_3()
    └─ 📄 individual_tasks.cs
        └─ namespace Project.pract_2
            └─ class individual_tasks
                ├─ public static void task_1()
                ├─ public static void task_2()

📁 practical_3
    └─ 📄 base_tasks.cs
        └─ namespace Project.pract_3
            └─ class base_tasks
                ├─ public static void task_1()
                ├─ public static void task_2()
                └─ public static void task_3()
    └─ 📄 individual_tasks.cs
        └─ namespace Project.pract_3
            └─ class individual_tasks
                ├─ public static void task_1()
                ├─ public static void task_2()

📁 practical_4
    └─ 📄 base_tasks.cs
        └─ namespace Project.pract_4
            └─ class base_tasks
                ├─ public static void task_1()
                ├─ public static void task_2()
                └─ public static void task_3()
    └─ 📄 individual_tasks.cs
        └─ namespace Project.pract_4
            └─ class individual_tasks
                ├─ public static void task_1()
                ├─ public static void task_2()

Репозиторій laboratory_works
└─ 📄 main.cs
        └─ class Project
            └─ Main()
└─ 📄 lab_1.cs
    └─ namespace Project.lab_1
        └─ class lab_1_task
            ├─ task_1()
            ├─ task_2()
            └─ task_3()
└─ 📄 lab_2.cs
    └─ namespace Project.lab_2
        └─ class lab_2_task
            ├─ task_1()
            ├─ task_2()
            └─ task_3()
└─ 📄 lab_3.cs
    └─ namespace Project.lab_3
        └─ class lab_3_task
            ├─ task_1()
            ├─ task_2()
            └─ task_3()