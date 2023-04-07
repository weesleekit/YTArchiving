using YTArchivingConsole.Models;

namespace YTArchivingConsole.Classes
{
    internal class DefaultConfiguration
    {
        internal static List<SubFolder> DefaultFolders = new()
        {
            new SubFolder() { Name = "Music",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCOxqgCwgOqC2lMqC5PYz_Dg",
                    Name = "Chillhop Music"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCSJ4gkVC6NrvII8umztf0Ow",
                    Name = "Lofi Girl"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCnfoJWazrLqjyUVAjYQrqAw",
                    Name = "lookatthesigns",
                    Description = "Cantonese music",
                    },
                },
            },

            new SubFolder() { Name = "TechNews",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCXuqSBlHAE6Xw-yeJA0Tunw",
                    Name = "Linus Tech Tips"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCBZiUUYeLfS5rIj4TQvgSvA",
                    Name = "Channel Super Fun"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC0KfjyvabuE2J-RBC6ko2Lw",
                    Name = "Mac Address"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCdBK94H6oZT2Q7l0-b0xmMg",
                    Name = "ShortCircuit"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCeeFfhMcJa1kjtfZAGskOCA",
                    Name = "TechLinked"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC0vBXGSyV14uvJ4hECDOl0Q",
                    Name = "Techquickie"
                    },

                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCMiJRAwDNSNzuYeN2uWa0pA",
                    Name = "Mrwhosetheboss"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCBJycsmduvYEL83R_U4JriQ",
                    Name = "Marques Brownlee"
                    },
                },
            },

            new SubFolder() { Name = "Life",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC3zoY9LapZERsN7caDKqz0w",
                    Name = "Archipel",
                    Description = "documentaries about Japanese artists and creators"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC3ScyryU9Oy9Wse3a8OAmYQ",
                    Name = "FRONTLINE PBS | Official"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCAuUUnT6oDeKwE6v1NGQxug",
                    Name = "TED"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCsT0YIqwnpJCM-mx7-gSA4Q",
                    Name = "TEDx Talks"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCq1wrWDJdth2NSV_eBX1SOA",
                    Name = "The Donegans"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCNepEAWZH0TBu7dkxIbluDw",
                    Name = "Dad, how do I?"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCjr2bPAyPV7t35MvcgT3W8Q",
                    Name = "The Hated One"
                    },
                },
            },

            new SubFolder() { Name = "DocumentaryFarmingAndTrades",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCekKN_0816MX4XIvom9bmEw",
                    Name = "The Sheep Game"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCmHlRvokjFiREW2Z5i02JcQ",
                    Name = "Tom Lamb"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCFqLPdQm-k5uCI9gFaxraeA",
                    Name = "Lost Trades - Eugenio Monesma"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCp-mnssZd4X2bgIcekaNfgA",
                    Name = "Marty T"
                    },
                },
            },

            new SubFolder() { Name = "EducationHistory",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC22BdTgxefuvUivrjesETjg",
                    Name = "History Matters"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCCODtTcd5M1JavPCOr_Uydg",
                    Name = "Extra History"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCNIuvl7V8zACPpTmmNIqP2A",
                    Name = "OverSimplified"
                    },
                },
            },
            
            new SubFolder() { Name = "EducationMisc",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCZ4AMrDcNrfy3X6nsU8-rPg",
                    Name = "Economics Explained"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCZHmFjS0jiocsfZBEANGhpw",
                    Name = "LetThemTalkTV",
                    Description = "English language"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC-WpvHaSBQEAztK6n_CupOg",
                    Name = "Brandon Y Lee"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCxzC4EngIsMrPmbm6Nxvb-A",
                    Name = "Scott Manley"
                    },
                },
            },
            
            new SubFolder() { Name = "EducationEssays",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC6nSFpj9HTCZ5t-N3Rm3-HA",
                    Name = "Vsauce"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCHnyfMqiRRG1u-2MsSQLbXA",
                    Name = "Veritasium"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCy0tKL1T7wFoYcxCe0xjN6Q",
                    Name = "Technology Connections"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UClRwC5Vc8HrB6vGx6Ti-lhA",
                    Name = "Technology Connextras"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCEIwxahdLz7bap-VDs9h35A",
                    Name = "Steve Mould"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCsXVk37bltHxD1rDPwtNM8Q",
                    Name = "Kurzgesagt In a Nutshell"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC2C_jShtL725hvbm1arSV9w",
                    Name = "CGP Grey"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC8XjmAEDVZSCQjI150cb4QA",
                    Name = "Knowing Better"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCX6b17PVsYBQ0ip5gyeme-Q",
                    Name = "CrashCourse"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCJkMlOu7faDgqh4PfzbpLdg",
                    Name = "Nerdwriter1"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC1DTYW241WD64ah5BFWn4JA",
                    Name = "Sam O'Nella Academy"
                    },
                },
            },
            
            new SubFolder() { Name = "EducationSTEM",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCSIvk78tK2TiviLQn4fSHaw",
                    Name = "Up and Atom"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC6107grRI4m0o2-emgoDnAA",
                    Name = "SmarterEveryDay"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UClu8Q445-ZAG1dzzP1mHiAw",
                    Name = "Engineering with Rosie"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC2bkHVIDjXS7sgrgjFtzOXQ",
                    Name = "engineerguy"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCJ0-OtVpF0wOKEqT2Z1HEtA",
                    Name = "ElectroBOOM"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC9-y-6csu5WGm29I7JiwpnA",
                    Name = "Computerphile"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCFhXFikryT4aFcLkLw2LBLA",
                    Name = "NileRed"
                    },
                },
            },
            
            new SubFolder() { Name = "EducationMaths",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCYO_jab_esuFRV4b17AJtAw",
                    Name = "3Blue1Brown"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCoxcjq-8xIDTYp3uz647V5A",
                    Name = "Numberphile"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCyp1gCHZJU_fGWFf2rtMkCg",
                    Name = "Numberphile2"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCSju5G2aFaWMqn-_0YBtq5A",
                    Name = "Stand-up Maths"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCtJPeNYnAXhB1-_h8xbIX_Q",
                    Name = "Nemean"
                    },
                },
            },
            
            new SubFolder() { Name = "EducationTomScotts",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCBa659QWEk1AI4Tg--mrJ2A",
                    Name = "Tom Scott"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCHC4G4X-OR5WkY-IquRGa3Q",
                    Name = "Tom Scott plus"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCRUULstZRWS1lDvJBzHnkXA",
                    Name = "Matt and Tom"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCR_i-r3a0vnlUJxEN4_5l3g",
                    Name = "Calum",
                    Description = "Similar to Tom Scott"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCYQfECqGcsrpjANI7ZgFNUQ",
                    Name = "Julian O'Shea",
                    Description = "Similar to Tom Scott"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCbCq5Y0WPGimG2jNXhoQxGw",
                    Name = "Atomic Frontier",
                    Description = "Similar to Tom Scott"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC2LVhJH_9cT2XKp0VAfsKOQ",
                    Name = "The Tim Traveller"
                    },
                },
            },
            
            new SubFolder() { Name = "Makers",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCY1kMZp36IQSyNx_9h4mpCg",
                    Name = "Mark Rober"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCj1VqrHhDte54oLgPG4xpuQ",
                    Name = "Stuff Made Here"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCXX7AV8HDBCZXbKRHJYYODg",
                    Name = "Estefannie"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCu7_D0o48KbfhpEohoP7YSQ",
                    Name = "Andreas Spiess",
                    Description = "Electronics"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCp68_FLety0O-n9QU6phsgw",
                    Name = "colinfurze"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCaI4Tib6te88f_P9r8w5Tmw",
                    Name = "Jackman Works",
                    Description = "wood working",
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCZdGJgHbmqQcVZaJCkqDRwg",
                    Name = "The Q"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCEn3fRj2e0mpqYsijxnzayg",
                    Name = "Xyla Foxlin"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC5NO8MgTQKHAWXp6z8Xl7yQ",
                    Name = "This Old Tony"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC67gfx2Fg7K2NSHqoENVgwA",
                    Name = "Tom Stanton"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCEgm-3RvRn4nCR-fGGVsfdQ",
                    Name = "Mattias Krantz"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCEaxX1yQlFPmAKbE6AFpBWQ",
                    Name = "MR HO THANH CHE"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC3KEoMzNz8eYnwBC34RaKCQ",
                    Name = "Simone Giertz"
                    },
                },
            },
            
            new SubFolder() { Name = "AI",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCkzW5JSFwvKRjXABI-UTAkQ",
                    Name = "Aladdin Persson",
                    Description = "AI"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCvKRFNawVcuz4b9ihUTApCg",
                    Name = "David Shapiro ~ AI"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC1H1NWNTG2Xi3pt85ykVSHA",
                    Name = "Jordan Harrod"
                    },
                },
            },
            
            new SubFolder() { Name = "GameReviews",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCWCw2Sd7RlYJ2yuNVHDWNOA",
                    Name = "Jim Sterling"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCy1Ms_5qBTawC-k7PVjHXKQ",
                    Name = "TotalBiscuit"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/watch?v=sAULfQXN5HQ&list=PLAbMhAYRuCUhawCEV2oXZGrienoKTN16X",
                    Name = "Zero Punctuation"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/watch?v=BJP82EMDBq0&list=PLAbMhAYRuCUjTFTU63WTuXDwT3bP3v2kN",
                    Name = "Extra Punctuation"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/watch?v=YEFn1rKlou4&list=PLAbMhAYRuCUghLNe-UtDHF_7gDlihvpo_",
                    Name = "Slightly Something Else"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/watch?v=FdsrpgnAdSk&list=PLAbMhAYRuCUiADjKik_07Icinz7foMk27",
                    Name = "Slightly Civil War"
                    },
                },
            },
            
            new SubFolder() { Name = "BoardGameReviews",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC3z8YEKBEjSPRb6L2RJPWUg",
                    Name = "Before You Play"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCyRhIGDUKdIOw07Pd8pHxCw",
                    Name = "Shut Up & Sit Down"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/watch?v=THjo1hjtz0g&list=PL7atuZxmT956cWFGxqSyRdn6GWhBxiAwE",
                    Name = "TableTop"
                    },
                },
            },
            
            new SubFolder() { Name = "GameDesign",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC0JB7TSe49lg56u6qH8y_MQ",
                    Name = "GDC"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCVzt0Ltq6VNKRqRMrry3OIA",
                    Name = "Extra Credits"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCqJ-Xo29CKyLTjn6z2XwYAw",
                    Name = "Game Maker's Toolkit"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCZB6V9fUov0Mx_us3MWWILg",
                    Name = "People Make Games"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCfHmyqCntYHQ81ZukNu66rg",
                    Name = "Razbuten"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC88I_nv3aeJg-P46mUOPTgg",
                    Name = "Stealth Docs"
                    },
                },
            },
            
            new SubFolder() { Name = "GameDocumentaries",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC0fDG3byEcMtbOqPMymDNbw",
                    Name = "Noclip - Video Game Documentaries"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCdievj3szPeYJzqqOjsLnfQ",
                    Name = "Noclip Crew"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCVWhVAZwCdQsPZL-mDLcxPQ",
                    Name = "Whitelight"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCSuhUzpdXg9jme6eN6HA_IA",
                    Name = "GVMERS"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCov_51F0betb6hJ6Gumxg3Q",
                    Name = "AI and Games"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCyNtlmLB73-7gtlBz00XOQQ",
                    Name = "Folding Ideas"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCJmgLa3XqyHk22XJI3vkV8A",
                    Name = "Games Over Coffee"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCnbvPS_rXp4PC21PG2k1UVg",
                    Name = "Gaming Historian"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC_0e1271DHhRyiDIuX6B6aQ",
                    Name = "ThatGuyGlen"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCQkd05iAYed2-LOmhjzDG6g",
                    Name = "LowSpecGamer"
                    },
                },
            },
            
            new SubFolder() { Name = "Cooking",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCdTLhjAGVI_XDAuXrobtI6Q",
                    Name = "Helen Rennie"
                    },
                },
            },
            
            new SubFolder() { Name = "GameDevBlogs",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCIabPXjvT5BVTxRDPCBBOOQ",
                    Name = "Dani"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCswdeChigkx5uN1PwgfTqzQ",
                    Name = "Game Dev Experiments"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UClaWNSOpRYRqi6Twk3GUG-A",
                    Name = "Rugbug Redfern"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCah7IyEzRnRdttwDGDdy_gw",
                    Name = "RujiK the Comatose"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCORkUj9eaM2aDJM1VYyDDTA",
                    Name = "Sam Hogan"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC3o8IDm9oNXdG8dqQvUPDnQ",
                    Name = "Tamara Makes Games"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCzW1rJo_rZgBMXP0FTSFsAg",
                    Name = "Thomas Stewart"
                    },
                },
            },
            
            new SubFolder() { Name = "GameDevTutorials",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCYbK_tjZ2OrIZFBvU6CCMiA",
                    Name = "Brackeys"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCdCwTHCqJqRuHMwMgsT5jdA",
                    Name = "Broken Knights Games"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCX_b3NNQN5bzExm-22-NVVg",
                    Name = "Jason Weimann"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCCkLMimnKzKbOQYxPDSYXFw",
                    Name = "samyam"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCAg2py6olXgod71Ix06HnUQ",
                    Name = "Tarodev"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCcAlTqd9zID6aNX3TzwxJXg",
                    Name = "The Art of Code"
                    },
                },
            },
            
            new SubFolder() { Name = "SoftwareDev",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCrkPsvLGln62OMZRO6K-llg",
                    Name = "Nick Chapsas"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCFbNIlppjAuEX4znoulh0Cw",
                    Name = "Web Dev Simplified"
                    },
                },
            },
            
            new SubFolder() { Name = "TechGuides",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC5UAwBUum7CPN5buc-_N1Fw",
                    Name = "The Linux Experiment"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCwFpzG5MK5Shg_ncAhrgr9g",
                    Name = "Awesome Open Source"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCUaMD_YaXS3IJMUMv7zetSw",
                    Name = "Android Privacy Lab"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCb8Rde3uRL1ohROUVg46h1A",
                    Name = "Thomas Sanladerer",
                    Description = "3D Printing Guides"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC2gyzKcHbYfqoXA5xbyGXtQ",
                    Name = "The Hook Up"
                    },
                },
            },
            
            new SubFolder() { Name = "Gardening",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCWsI0LmiDyezbnN2JCL4P9w",
                    Name = "Gardener Scott"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UC9r61qohBg1qgGty4_WzojA",
                    Name = "GrowVeg"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCdr8IulnjLc3-zpwiCVTaiw",
                    Name = "LawnsmithTV"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCGwHWxpp7vxEZ3jgsOuD0Xg",
                    Name = "The Ripe Tomato Farms"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCd9ITcyID2MERVxfuryPTsA",
                    Name = "ReSprout"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCJZTjBlrnDHYmf0F-eYXA3Q",
                    Name = "Self Sufficient Me"
                    },
                },
            },
            
            new SubFolder() { Name = "DND",
                Subscriptions = new()
                {
                    new Subscription{
                    URL = "https://www.youtube.com/@criticalrole",
                    Name = "Critical Role"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCkVdb9Yr8fc05_VbAVfskCA",
                    Name = "Matthew Colville"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/channel/UCd83kSpJ-jJGCE_L8Yaoakg",
                    Name = "The Third Wheel"
                    },
                    new Subscription{
                    URL = "https://www.youtube.com/playlist?list=PLAbMhAYRuCUjVHYKrFs03yA1muKEcv62e",
                    Name = "Adventure is Nigh!"
                    },
                },
            },
        };
    }
}