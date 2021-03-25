using BaseApp.Entity;
using BaseApp.Models;
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new OlimpicDBContext())
            {
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Archery",
                    
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                             Name="Individual",
                              LengthLimite=new Models.LengthLimite()
                              {
                                   MaxLength=70
                              }
                        },
                        new Models.SportType()
                        {
                            Name="Team",
                            LengthLimite=new Models.LengthLimite()
                            {
                                 MaxLength=70
                            }
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                     Name = "Badminton",
                     SportTypes = new List<Models.SportType>()
                     {
                         new Models.SportType()
                         {
                              Name="Doubles men",                              
                         },
                         new Models.SportType()
                         {
                              Name="Doubles women"
                         },
                         new Models.SportType()
                         {
                              Name="Singles men"
                         },
                         new Models.SportType()
                         {
                              Name="Singles men"
                         }
                     }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Basketball",
                     SportTypes=new List<Models.SportType>()
                     {
                         new Models.SportType()
                         {
                              Name="Basketball 3x3"
                         }
                     }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Boxing",
                    SportTypes = new List<Models.SportType>()
                      {
                          new Models.SportType()
                          {
                               Name="Super heavyweight",
                                WeightLimite=new Models.WeightLimite()
                                {
                                     MaxWeight=92
                                }
                          },
                          new Models.SportType()
                          {
                               Name="Light flyweight",
                               WeightLimite=new Models.WeightLimite()
                               {
                                   MaxWeight=49,
                                   MinWeight=46
                               }
                          },
                          new Models.SportType()
                          {
                              Name="Flyweight",
                              WeightLimite=new Models.WeightLimite()
                              {
                                   MaxWeight=52
                              }
                          },
                          new Models.SportType()
                          {
                              Name="Bantam weight",
                              WeightLimite=new Models.WeightLimite()
                              {
                                  MaxWeight=56
                              }
                          },
                          new Models.SportType()
                          {
                              Name="Light weight",
                              WeightLimite=new Models.WeightLimite()
                              {
                                   MaxWeight=60
                              }
                          }
                      }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Cycling",
                    SportTypes = new List<Models.SportType>()
                      {
                          new Models.SportType()
                          {
                               Name="BMX"
                          },
                          new Models.SportType()
                          {
                              Name="Mountain bike"
                          },
                          new Models.SportType()
                          {
                               Name="Road"
                          },
                          new Models.SportType()
                          {
                              Name="Track"
                          }
                      }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Diving",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="Platform",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=10
                            }
                        },
                        new Models.SportType()
                        {
                            Name="SPRINGBOARD",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=3
                            }
                        },
                        new Models.SportType()
                        {
                            Name="SYNCHRONIZED DIVING PLATFORM ",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=10
                            }
                        },
                        new Models.SportType()
                        {
                            Name="SYNCHRONIZED DIVING SPRINGBOARD",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=3
                            }
                        }
                    }
                });

                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Equestrian",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="Dressage"
                        },
                        new Models.SportType()
                        {
                            Name="Eventing"
                        },
                        new Models.SportType()
                        {
                            Name="Jumping"
                        }
                    }
                });

                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Fencing",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="ÉPÉE INDIVIDUAL"
                        },
                        new Models.SportType()
                        {
                            Name="ÉPÉE TEAM"
                        },
                        new Models.SportType()
                        {
                            Name="FOIL INDIVIDUAL"
                        },
                        new Models.SportType()
                        {
                            Name="SABRE INDIVIDUAL"
                        },
                        new Models.SportType()
                        {
                            Name="SABRE TEAM"
                        }
                    }
                });

                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Football"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Golf"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Gymnastics",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="FLOOR EXERCISES"
                        },
                        new Models.SportType()
                        {
                            Name="HORIZONTAL BAR"
                        },
                        new Models.SportType()
                        {
                            Name="INDIVIDUAL ALL-ROUND",
                        },
                        new Models.SportType()
                        {
                            Name="PARALLEL BARS"
                        },
                        new Models.SportType()
                        {
                            Name="POMMEL HORSE"
                        },
                        new Models.SportType()
                        {
                            Name="TEAM COMPETITION"
                        },
                        new Models.SportType()
                        {
                            Name="BEAM"
                        },
                        new Models.SportType()
                        {
                            Name="FLOOR EXERCISES"
                        },
                        new Models.SportType()
                        {
                            Name="RHYTHMIC"
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Handball"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Hockey"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Judo",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                             Name="Normally",
                             WeightLimite=new Models.WeightLimite()
                             {
                                  MaxWeight=60
                             }
                        },
                        new Models.SportType()
                        {
                            Name="HEAVYWEIGHT",
                            WeightLimite=new Models.WeightLimite()
                            {
                                 MaxWeight=100
                            }
                        },
                        new Models.SportType()
                        {
                            Name="HALF-LIGHTWEIGHT",
                            WeightLimite=new Models.WeightLimite()
                            {
                                 MaxWeight=66,
                                 MinWeight=60
                            }
                        },
                        new Models.SportType()
                        {
                            Name="LIGHTWEIGHT",
                            WeightLimite=new Models.WeightLimite()
                            {
                                 MinWeight=66,
                                 MaxWeight=73
                            }
                        },
                        new Models.SportType()
                        {
                            Name="HALF-HEAVYWEIGHT",
                            WeightLimite=new Models.WeightLimite()
                            {
                                MaxWeight=100,
                                MinWeight=90
                            }
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Karate",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                             Name="KATA"
                        },
                        new Models.SportType()
                        {
                            Name="KUMITE",
                             WeightLimite=new Models.WeightLimite()
                             {
                                  MaxWeight=75,
                                  MinWeight=67
                             }
                        }
                    }
                });

                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Rowing",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="LIGHTWEIGHT COXLESS FOUR (4-)"
                        },
                        new Models.SportType()
                        {
                            Name="PAIRS"
                        },
                        new Models.SportType()
                        {
                            Name="SINGLE SCULLS"
                        },
                        new Models.SportType()
                        {
                            Name="DOUBLE SCULLS"
                        },
                        new Models.SportType()
                        {
                            Name="EIGHT"
                        },
                        new Models.SportType()
                        {
                            Name="FOUR"
                        },
                        new Models.SportType()
                        {
                            Name="LIGHTWEIGHT DOUBLE SCULLS"
                        },
                        new Models.SportType()
                        {
                            Name="QUADRUPLE SCULLS"
                        },
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Rugby",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="RUGBY-7"
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Sailing",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="470 - TWO PERSON DINGHY"
                        },
                        new Models.SportType()
                        {
                            Name="49ER - SKIFF"
                        },
                        new Models.SportType()
                        {
                            Name="FINN - ONE PERSON DINGHY (HEAVYWEIGHT)"
                        },
                        new Models.SportType()
                        {
                            Name="LASER - ONE PERSON DINGHY"
                        },
                        new Models.SportType()
                        {
                            Name="RS:X - WINDSURFER MEN"
                        }
                    }
                });

                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Shooting",
                    SportTypes = new List<Models.SportType>()
                     {
                          new Models.SportType()
                          {
                               Name="AIR PISTOL",
                               LengthLimite=new Models.LengthLimite()
                               {
                                    MaxLength=10
                               }
                          },
                          new Models.SportType()
                          {
                              Name="AIR RIFLE",
                              LengthLimite=new Models.LengthLimite()
                              {
                                  MaxLength=10
                              }
                          },
                          new Models.SportType()
                          {
                              Name="RAPID FIRE PISTOL",
                              LengthLimite=new Models.LengthLimite()
                              {
                                   MaxLength=25
                              }
                          },
                          new Models.SportType()
                          {
                              Name="RIFLE 3 POSITIONS",
                              LengthLimite=new Models.LengthLimite()
                              {
                                   MaxLength=50
                              }
                          },
                          new Models.SportType()
                          {
                              Name="SHOT GUN SKEET"
                          },
                          new Models.SportType()
                          {
                              Name="SHOT GUN TRAP"
                          }
                     }
                });

                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Skateboarding",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="PARK"
                        },
                        new Models.SportType()
                        {
                            Name="STREET"
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Sport climbing"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Surfing"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Swimming",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="BACKSTROKE",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=100
                            }
                        },
                        new Models.SportType()
                        {
                            Name="BREASTSTROKE",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=100
                            }
                        },
                        new Models.SportType()
                        {
                            Name="BUTTERFLY",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=100
                            }
                        },
                        new Models.SportType()
                        {
                            Name=" FREESTYLE",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=100
                            }
                        },
                        new Models.SportType()
                        {
                            Name="INDIVIDUAL MEDLEY",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=200
                            }
                        },
                        new Models.SportType()
                        {
                            Name="MEDLEY RELAY",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=400
                            }
                        },
                        new Models.SportType()
                        {
                            Name="MARATHON",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=10000
                            }
                        }                                       
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Taekwondo",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MaxWeight=80
                             }
                        },
                        new Models.SportType()
                        {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=58,
                                 MaxWeight=68
                             }
                        },
                        new Models.SportType()
                        {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MaxWeight=58
                             }
                        },
                        new Models.SportType()
                        {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=68,
                                 MaxWeight=80
                             }
                        }
                    }
                });

                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Tennis",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="Table tennis"
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Trampoline"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Triathlon"
                });

                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Volleyball",
                    SportTypes = new List<Models.SportType>()
                     {
                         new Models.SportType()
                         {
                              Name="Beach volleyball"
                         }
                     }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Water polo"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Weightlifting",
                    SportTypes=new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            WeightLimite=new Models.WeightLimite()
                            {
                                MaxWeight=106
                            }
                        },
                        new Models.SportType()
                        {
                            WeightLimite=new Models.WeightLimite()
                            {
                                MaxWeight=105
                            }
                        },
                        new Models.SportType()
                        {
                            WeightLimite=new Models.WeightLimite()
                            {
                                MaxWeight=94
                            }
                        },
                        new Models.SportType()
                        {
                            WeightLimite=new Models.WeightLimite()
                            {
                                MaxWeight=85
                            }
                        },
                        new Models.SportType()
                        {
                            WeightLimite=new Models.WeightLimite()
                            {
                                MaxWeight=77
                            }
                        },
                        new Models.SportType()
                        {
                            WeightLimite=new Models.WeightLimite()
                            {
                                MaxWeight=69
                            }
                        },
                        new Models.SportType()
                        {
                            WeightLimite=new Models.WeightLimite()
                            {
                                MaxWeight=62
                            }
                        },
                        new Models.SportType()
                        {
                            WeightLimite=new Models.WeightLimite()
                            {
                                MaxWeight=56
                            }
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Wrestling freestyle",                   
                    SportTypes = new List<Models.SportType>()
                    {                         
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                  MaxWeight=55
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                  MinWeight=55,
                                  MaxWeight=60
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=60,
                                 MaxWeight=66
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=66,
                                 MaxWeight=74
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=74,
                                 MaxWeight=84
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=84,
                                 MaxWeight=96
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=96,
                                 MaxWeight=120
                             }
                         }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Wrestling Greco-Roman",
                    SportTypes = new List<Models.SportType>()
                    {
                         new Models.SportType()
                         {  
                             WeightLimite=new Models.WeightLimite()
                             {
                                  MaxWeight=55
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                  MinWeight=55,
                                  MaxWeight=60
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=60,
                                 MaxWeight=66
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=66,
                                 MaxWeight=74
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=74,
                                 MaxWeight=84
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=84,
                                 MaxWeight=96
                             }
                         },
                         new Models.SportType()
                         {
                             WeightLimite=new Models.WeightLimite()
                             {
                                 MinWeight=96,
                                 MaxWeight=120
                             }
                         }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Alpine sking",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="ALPINE COMBINED"
                        },
                        new Models.SportType()
                        {
                            Name="DOWNHILL"
                        },
                        new Models.SportType()
                        {
                            Name="GIANT SLALOM"
                        },
                        new Models.SportType()
                        {
                            Name="SLALOM"
                        },
                        new Models.SportType()
                        {
                            Name="SUPER-G"
                        }
                    }
                });
                
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Biathlon",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="Sprint",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=10000
                            }
                        },
                        new Models.SportType()
                        {
                            Name="Pursuit",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=12500
                            }
                        },
                        new Models.SportType()
                        {
                            Name="Mass start",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=15000
                            }
                        },
                        new Models.SportType()
                        {
                            Name="Individual",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=20000
                            }
                        },
                        new Models.SportType()
                        {
                            Name="Relay",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=30000
                            }
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name="Bobsleigh"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Cross country skiing",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="Free",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=15000
                            }
                        },
                        new Models.SportType()
                        {
                            Name="SKIATHLON",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=30000
                            }
                        },
                        new Models.SportType()
                        {
                            Name="RELAY",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=40000
                            }
                        },
                        new Models.SportType()
                        {
                            Name="MASS START CLASSIC",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=50000
                            }
                        },
                        new Models.SportType()
                        {
                            Name="SPRINT CLASSIC"
                        },
                        new Models.SportType()
                        {
                            Name="TEAM SPRINT FREE"
                        }
                    }
                });

                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Curling"
                });               
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Figure skating"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Freestyle skiing",
                    SportTypes=new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="AERIALS"
                        },
                        new Models.SportType()
                        {
                            Name="MOGULS"
                        },
                        new Models.SportType()
                        {
                            Name="SKI CROSS"
                        },
                        new Models.SportType()
                        {
                            Name="SKI HALFPIPE"
                        },
                        new Models.SportType()
                        {
                            Name="SKI SLOPESTYLE"
                        },
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Ice hockey"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Luge"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Nordic Combined",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                             Name="INDIVIDUAL GUNDERSEN LARGE HILL",
                             LengthLimite=new Models.LengthLimite()
                             {
                                 MaxLength=10000
                             }
                        },
                        new Models.SportType()
                        {
                            Name="INDIVIDUAL GUNDERSEN NORMAL HILL",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=10000
                            }
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Short track speed skating",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=1000
                            }
                        },
                        new Models.SportType()
                        {
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=1500
                            }
                        },
                        new Models.SportType()
                        {
                            Name="Relay",
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=5000
                            }
                        },
                        new Models.SportType()
                        {
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=500
                            }
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Skeleton"
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Ski jumping",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                             Name="LARGE HILL INDIVIDUAL"
                        },
                        new Models.SportType()
                        {
                            Name="NORMAL HILL INDIVIDUAL"
                        },
                        new Models.SportType()
                        {
                            Name="TEAM"
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Snowboard",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                            Name="BIG AIR"
                        },
                        new Models.SportType()
                        {
                            Name="HALFPIPE"
                        },
                        new Models.SportType()
                        {
                            Name="PARALLEL GIANT SLALOM"
                        },
                        new Models.SportType()
                        {
                            Name="SLOPESTYLE"
                        },
                        new Models.SportType()
                        {
                            Name="SNOWBOARD CROSS"
                        }
                    }
                });
                db.SportTypes.Add(new Models.SportType()
                {
                    Name = "Speed skating",
                    SportTypes = new List<Models.SportType>()
                    {
                        new Models.SportType()
                        {
                           LengthLimite=new Models.LengthLimite()
                           {
                               MaxLength=10000
                           }
                        },
                        new Models.SportType()
                        {
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=1000
                            }
                        },
                        new Models.SportType()
                        {
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=1500
                            }
                        },
                        new Models.SportType()
                        {
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=5000
                            }
                        },
                        new Models.SportType()
                        {
                            LengthLimite=new Models.LengthLimite()
                            {
                                MaxLength=500
                            }
                        },
                        new Models.SportType()
                        {
                            Name="MASS START"
                        },
                        new Models.SportType()
                        {
                            Name="TEAM PURSUIT"
                        }
                    }
                });
                //db.SaveChanges();               
            };

            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\Users\Samsung PC\Desktop\OlympicProject\Turkey.csv")), true))
            {
                csvTable.Load(csvReader);                

                using (var db = new OlimpicDBContext())
                {
                    for (int i = 0; i < csvTable.Rows.Count; i++)
                    {
                        db.Athlets.Add(new Models.Athlet()
                        {
                            Id=int.Parse(csvTable.Rows[i][0].ToString()),
                            FirstName = csvTable.Rows[i][1].ToString(),
                            LastName = csvTable.Rows[i][2].ToString(),
                            BirthDate = DateTime.Parse(csvTable.Rows[i][3].ToString()),
                            Weight = double.Parse(csvTable.Rows[i][4].ToString()),
                            Score = int.Parse(csvTable.Rows[i][5].ToString()),
                            //Gender = db.Genders.FirstOrDefault(x => x.Id == ((csvTable.Rows[i][6]) as Gender).Id)
                        });                       
                    }
                    //db.SaveChanges();
                }
            }


        }
    }    
}
