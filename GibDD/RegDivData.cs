
using System.Collections.Generic;

namespace GibDD
{
    public class RegDivData
    {
        public class Subdivision
        {
            public int Id = -1;
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        public class Region
        {
            public static readonly Region Empty = new Region();

            public int Id = -1;
            public string Name { get; set; }
            public List<Subdivision> Subdivisions { get; set; } = new List<Subdivision>();

            public string DisplayName => $"{Id} {Name}";

            public override string ToString()
            {
                return DisplayName;
            }
        }

        public static List<Region> Regions { get; private set; } = new List<Region>()
        {
            new Region()
            {
                Id = 01,
                Name = "Республика Адыгея",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 1,
                        Name = "УГИБДД МВД по Республике Адыгея"
                    }
                }
            },
            new Region()
            {
                Id = 02,
                Name = "Республика Башкортостан",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 3,
                        Name = "УГИБДД МВД по Республике Башкортостан"
                    }
                }
            },
            new Region()
            {
                Id = 03,
                Name = "Республика Бурятия",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 4,
                        Name = "УГИБДД МВД по Республике Бурятия"
                    }
                }
            },
            new Region()
            {
                Id = 04,
                Name = "Республика Алтай",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 2,
                        Name = "УГИБДД МВД по Республике Алтай"
                    }
                }
            },
            new Region()
            {
                Id = 05,
                Name = "Республика Дагестан",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 5,
                        Name = "УГИБДД МВД по Республике Дагестан"
                    }
                }
            },
            new Region()
            {
                Id = 06,
                Name = "Республика Ингушетия",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 6,
                        Name = "УГИБДД МВД по Республике Ингушетия"
                    }
                }
            },
            new Region()
            {
                Id = 07,
                Name = "Кабардино-Балкарская Республика",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 7,
                        Name = "УГИБДД МВД по Кабардино-Балкарской Республике"
                    }
                }
            },
            new Region()
            {
                Id = 08,
                Name = "Республика Калмыкия",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 2934,
                        Name = "Отдел ГИБДД МВД по РК (Республика Калмыкия)"
                    }
                }
            },
            new Region()
            {
                Id = 09,
                Name = "Карачаево-Черкесская Республика",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 9,
                        Name = "УГИБДД МВД по Карачаево-Черкесской Республике"
                    }
                }
            },
            new Region()
            {
                Id = 10,
                Name = "Республика Карелия",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 10,
                        Name = "УГИБДД МВД по Республике Карелия"
                    }
                }
            },
            new Region()
            {
                Id = 11,
                Name = "Республика Коми",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 11,
                        Name = "УГИБДД МВД по Республике Коми"
                    }
                }
            },
            new Region()
            {
                Id = 12,
                Name = "Республика Марий Эл",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 2910,
                        Name = "УГИБДД МВД по Республике Марий Эл"
                    }
                }
            },
            new Region()
            {
                Id = 13,
                Name = "Республика Мордовия",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 12,
                        Name = "УГИБДД МВД по Республике Мордовия"
                    }
                }
            },
            new Region()
            {
                Id = 14,
                Name = "Республика Саха (Якутия)",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 13,
                        Name = "УГИБДД МВД по Республике Саха (Якутия)"
                    }
                }
            },
            new Region()
            {
                Id = 15,
                Name = "Республика Северная Осетия - Алания",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 14,
                        Name = "УГИБДД МВД по Республике Северная Осетия-Алания"
                    }
                }
            },
            new Region()
            {
                Id = 16,
                Name = "Республика Татарстан",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 15,
                        Name = "УГИБДД МВД по Республике Татарстан"
                    }
                }
            },
            new Region()
            {
                Id = 17,
                Name = "Республика Тыва",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 16,
                        Name = "УГИБДД МВД по Республике Тыва"
                    }
                }
            },
            new Region()
            {
                Id = 18,
                Name = "Удмуртская Республика",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 17,
                        Name = "УГИБДД МВД по Удмуртской Республике"
                    }
                }
            },
            new Region()
            {
                Id = 19,
                Name = "Республика Хакасия",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 18,
                        Name = "УГИБДД МВД по Республике Хакасия"
                    }
                }
            },
            new Region()
            {
                Id = 21,
                Name = "Чувашская Республика - Чувашия",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 19,
                        Name = "УГИБДД МВД по Чувашской Республике"
                    }
                }
            },
            new Region()
            {
                Id = 22,
                Name = "Алтайский край",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 3963,
                        Name = "УГИБДД ГУ МВД России по Алтайскому краю"
                    }
                }
            },
            new Region()
            {
                Id = 23,
                Name = "Краснодарский край",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 20,
                        Name = "УГИБДД ГУ МВД России по Краснодарскому краю"
                    }
                }
            },
            new Region()
            {
                Id = 24,
                Name = "Красноярский край",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 21,
                        Name = "УГИБДД ГУ МВД России по Красноярскому краю"
                    }
                }
            },
            new Region()
            {
                Id = 25,
                Name = "Приморский край",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 23,
                        Name = "УГИБДД УМВД России по Приморскому краю"
                    }
                }
            },
            new Region()
            {
                Id = 26,
                Name = "Ставропольский край",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 24,
                        Name = "УГИБДД ГУ МВД России по Ставропольскому краю"
                    }
                }
            },
            new Region()
            {
                Id = 27,
                Name = "Хабаровский край",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 25,
                        Name = "УГИБДД УМВД России по Хабаровскому краю"
                    }
                }
            },
            new Region()
            {
                Id = 28,
                Name = "Амурская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 26,
                        Name = "УГИБДД УМВД России по Амурской области"
                    }
                }
            },
            new Region()
            {
                Id = 29,
                Name = "Архангельская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 27,
                        Name = "УГИБДД УМВД России по Архангельской области"
                    }
                }
            },
            new Region()
            {
                Id = 30,
                Name = "Астраханская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 28,
                        Name = "УГИБДД УМВД России по Астраханской области"
                    }
                }
            },
            new Region()
            {
                Id = 31,
                Name = "Белгородская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 29,
                        Name = "УГИБДД УМВД России по Белгородской области"
                    }
                }
            },
            new Region()
            {
                Id = 32,
                Name = "Брянская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 2944,
                        Name = "УГИБДД УМВД России по Брянской области"
                    }
                }
            },
            new Region()
            {
                Id = 33,
                Name = "Владимирская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 30,
                        Name = "УГИБДД УМВД России по Владимирской области"
                    }
                }
            },
            new Region()
            {
                Id = 34,
                Name = "Волгоградская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 31,
                        Name = "УГИБДД ГУ МВД России по Волгоградской области"
                    },
                    new Subdivision()
                    {
                        Id = 2924,
                        Name = "ЦАФАПОДД ГИБДД ГУ МВД России по Волгоградской области"
                    }
                }
            },
            new Region()
            {
                Id = 35,
                Name = "Вологодская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 32,
                        Name = "УГИБДД УМВД России по Вологодской области"
                    }
                }
            },
            new Region()
            {
                Id = 36,
                Name = "Воронежская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 33,
                        Name = "УГИБДД ГУ МВД России по Воронежской области"
                    }
                }
            },
            new Region()
            {
                Id = 37,
                Name = "Ивановская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 2875,
                        Name = "УГИБДД УМВД России по Ивановской области"
                    }
                }
            },
            new Region()
            {
                Id = 38,
                Name = "Иркутская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 34,
                        Name = "УГИБДД ГУ МВД России по Иркутской области"
                    }
                }
            },
            new Region()
            {
                Id = 39,
                Name = "Калининградская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 2865,
                        Name = "УГИБДД УМВД России по Калининградской области"
                    }
                }
            },
            new Region()
            {
                Id = 40,
                Name = "Калужская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 35,
                        Name = "УГИБДД УМВД России по Калужской области"
                    }
                }
            },
            new Region()
            {
                Id = 41,
                Name = "Камчатский край",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 36,
                        Name = "УГИБДД УМВД России по Камчатскому краю"
                    }
                }
            },
            new Region()
            {
                Id = 42,
                Name = "Кемеровская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 37,
                        Name = "УГИБДД ГУ МВД России по Кемеровской области"
                    }
                }
            },
            new Region()
            {
                Id = 43,
                Name = "Кировская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 38,
                        Name = "УГИБДД УМВД России по Кировской области"
                    }
                }
            },
            new Region()
            {
                Id = 44,
                Name = "Костромская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 39,
                        Name = "УГИБДД УМВД России по Костромской области"
                    }
                }
            },
            new Region()
            {
                Id = 45,
                Name = "Курганская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 40,
                        Name = "УГИБДД УМВД России по Курганской области"
                    }
                }
            },
            new Region()
            {
                Id = 46,
                Name = "Курская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 2876,
                        Name = "УГИБДД УМВД России по Курской области"
                    }
                }
            },
            new Region()
            {
                Id = 47,
                Name = "Ленинградская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 41,
                        Name = "УГИБДД ГУ МВД России по г. Санкт-Петербургу и Ленинградской области"
                    }
                }
            },
            new Region()
            {
                Id = 48,
                Name = "Липецкая область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 42,
                        Name = "УГИБДД УМВД России по Липецкой области"
                    }
                }
            },
            new Region()
            {
                Id = 49,
                Name = "Магаданская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 4348,
                        Name = "УГИБДД УМВД России по Магаданской области"
                    }
                }
            },
            new Region()
            {
                Id = 50,
                Name = "Московская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 43,
                        Name = "УГИБДД ГУ МВД России по Московской области"
                    }
                }
            },
            new Region()
            {
                Id = 51,
                Name = "Мурманская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 1764,
                        Name = "УГИБДД УМВД России по Мурманской области"
                    }
                }
            },
            new Region()
            {
                Id = 52,
                Name = "Нижегородская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 2786,
                        Name = "УГИБДД ГУ МВД России по Нижегородской области"
                    },
                    new Subdivision()
                    {
                        Id = 4147,
                        Name = "ЦАФАП ОДД ГИБДД ГУ МВД России по Нижегородской области"
                    }
                }
            },
            new Region()
            {
                Id = 53,
                Name = "Новгородская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 44,
                        Name = "УГИБДД УМВД России по Новгородской области"
                    }
                }
            },
            new Region()
            {
                Id = 54,
                Name = "Новосибирская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 45,
                        Name = "УГИБДД ГУ МВД России по Новосибирской области"
                    }
                }
            },
            new Region()
            {
                Id = 55,
                Name = "Омская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 46,
                        Name = "УГИБДД  УМВД России по Омской области"
                    }
                }
            },
            new Region()
            {
                Id = 56,
                Name = "Оренбургская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 47,
                        Name = "УГИБДД УМВД России по Оренбургской области"
                    }
                }
            },
            new Region()
            {
                Id = 57,
                Name = "Орловская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 48,
                        Name = "УГИБДД УМВД России по Орловской области"
                    },
                    new Subdivision()
                    {
                        Id = 2183,
                        Name = "ЦАФАПОДД ГИБДД УМВД России по Орловской области"
                    }
                }
            },
            new Region()
            {
                Id = 58,
                Name = "Пензенская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 49,
                        Name = "УГИБДД УМВД России по Пензенской области"
                    }
                }
            },
            new Region()
            {
                Id = 59,
                Name = "Пермский край",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 22,
                        Name = "УГИБДД ГУ МВД России по Пермскому краю"
                    }
                }
            },
            new Region()
            {
                Id = 60,
                Name = "Псковская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 50,
                        Name = "УГИБДД УМВД России по Псковской области"
                    }
                }
            },
            new Region()
            {
                Id = 61,
                Name = "Ростовская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 51,
                        Name = "УГИБДД ГУ МВД России по Ростовской области"
                    }
                }
            },
            new Region()
            {
                Id = 62,
                Name = "Рязанская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 52,
                        Name = "УГИБДД УМВД России по Рязанской области"
                    }
                }
            },
            new Region()
            {
                Id = 63,
                Name = "Самарская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 53,
                        Name = "УГИБДД ГУ МВД России по Самарской области"
                    }
                }
            },
            new Region()
            {
                Id = 64,
                Name = "Саратовская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 54,
                        Name = "УГИБДД ГУ МВД России по Саратовской области"
                    }
                }
            },
            new Region()
            {
                Id = 65,
                Name = "Сахалинская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 55,
                        Name = "УГИБДД УМВД России по Сахалинской области"
                    }
                }
            },
            new Region()
            {
                Id = 66,
                Name = "Свердловская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 703,
                        Name = "УГИБДД ГУ МВД России по Свердловской области"
                    }
                }
            },
            new Region()
            {
                Id = 67,
                Name = "Смоленская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 57,
                        Name = "УГИБДД УМВД России по Смоленской области"
                    },
                    new Subdivision()
                    {
                        Id = 2449,
                        Name = "ЦАФАП ГИБДД УМВД России по Смоленской области"
                    }
                }
            },
            new Region()
            {
                Id = 68,
                Name = "Тамбовская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 58,
                        Name = "УГИБДД УМВД России по Тамбовской области"
                    }
                }
            },
            new Region()
            {
                Id = 69,
                Name = "Тверская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 59,
                        Name = "УГИБДД УМВД России по Тверской области"
                    },
                    new Subdivision()
                    {
                        Id = 2783,
                        Name = "ЦАФАП ГИБДД УМВД России по Тверской области"
                    }
                }
            },
            new Region()
            {
                Id = 70,
                Name = "Томская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 60,
                        Name = "УГИБДД УМВД России по Томской области"
                    }
                }
            },
            new Region()
            {
                Id = 71,
                Name = "Тульская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 61,
                        Name = "УГИБДД УМВД России по Тульской области"
                    }
                }
            },
            new Region()
            {
                Id = 72,
                Name = "Тюменская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 62,
                        Name = "УГИБДД  УМВД России по Тюменской области"
                    }
                }
            },
            new Region()
            {
                Id = 73,
                Name = "Ульяновская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 63,
                        Name = "УГИБДД УМВД России по Ульяновской области"
                    }
                }
            },
            new Region()
            {
                Id = 74,
                Name = "Челябинская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 64,
                        Name = "УГИБДД ГУ МВД России по Челябинской области"
                    }
                }
            },
            new Region()
            {
                Id = 75,
                Name = "Забайкальский край",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 65,
                        Name = "Управление ГИБДД УМВД России по Забайкальскому краю"
                    }
                }
            },
            new Region()
            {
                Id = 76,
                Name = "Ярославская область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 66,
                        Name = "УГИБДД УМВД России по Ярославской области"
                    }
                }
            },
            new Region()
            {
                Id = 77,
                Name = "г. Москва",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 67,
                        Name = "УГИБДД ГУ МВД России по г. Москве"
                    }
                }
            },
            new Region()
            {
                Id = 78,
                Name = "г. Санкт-Петербург",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 41,
                        Name = "УГИБДД ГУ МВД России по г. Санкт-Петербургу и Ленинградской области"
                    }
                }
            },
            new Region()
            {
                Id = 79,
                Name = "Еврейская автономная область",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 68,
                        Name = "ОГИБДД УМВД России по Еврейской автономной области"
                    }
                }
            },
            new Region()
            {
                Id = 82,
                Name = "Республика Крым",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 4207,
                        Name = "УГИБДД МВД по Республике Крым"
                    }
                }
            },
            new Region()
            {
                Id = 83,
                Name = "Ненецкий автономный округ",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 69,
                        Name = "ОГИБДД УМВД России по Ненецкому автономному округу"
                    }
                }
            },
            new Region()
            {
                Id = 86,
                Name = "Ханты-Мансийский автономный округ - Югра",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 70,
                        Name = "УГИБДД УМВД России по Ханты-Мансийскому автономному округу - Югре"
                    }
                }
            },
            new Region()
            {
                Id = 87,
                Name = "Чукотский автономный округ",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 71,
                        Name = "Отдел ГИБДД УМВД России по Чукотскому автономному округу"
                    }
                }
            },
            new Region()
            {
                Id = 89,
                Name = "Ямало-Ненецкий автономный округ",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 72,
                        Name = "УГИБДД УМВД России по Ямало-Ненецкому автономному округу"
                    }
                }
            },
            new Region()
            {
                Id = 92,
                Name = "Севастополь",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 4208,
                        Name = "УГИБДД УМВД России по г. Севастополю"
                    }
                }
            },
            new Region()
            {
                Id = 95,
                Name = "Чеченская Республика",
                Subdivisions = new List<Subdivision>()
                {
                    new Subdivision()
                    {
                        Id = 4010,
                        Name = "УГИБДД МВД по Чеченской Республике"
                    }
                }
            }
        };
    }
}