using System;
using PatternsCore.FrameWorkStyleFactory.AbstractFactory.AnotherIsolatedExample;

namespace PatternAtWork.Factory
    {
        public class CarExampleAbstractFactory
            {
                public CarExampleAbstractFactory()
                    {
                        for (;true;)
                            {
                                ICarStore store;
                                Console.Out.Write("Please Select your car store [1 for Ferrari 2 for Prius]");
                                string userInput = Console.In.ReadLine();

                                if (userInput == "1")
                                    {
                                        store = new FerrariStore();
                                        Console.Out.WriteLine(store.BuildMyCar(new FerrariBuilder()).GetCar());
                                    }
                                else if (userInput == "2")
                                    {
                                        store = new PriusStore();
                                        Console.Out.WriteLine(store.BuildMyCar(new PriusBuilder()).GetCar());
                                    }
                                else
                                    break;
                            }
                    }
            }
    }