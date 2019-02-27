/*
    Fumik0_
    Araragi
    27 February 2019

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR 
    OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR 
    THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Linq;
using System.Collections.Generic;

namespace PoC_AntiVM
{
    class Program
    {
        private List<float?> PowerUsage = new List<float?>();
        private OpenHardwareMonitor.Hardware.Computer computer;

        private void InitHardware() {
            computer = new OpenHardwareMonitor.Hardware.Computer();
            computer.CPUEnabled = true;
            computer.Open();
            return;
        }

        private void GetPowerUsage() {
            string SensorType;
            float? SensorValue;
            
            for(int i = 0; i < computer.Hardware.Count() ; i++) { 
                for(int j = 0; j < computer.Hardware[i].Sensors.Count(); j++) {
                    SensorType = computer.Hardware[i].Sensors[j].SensorType.ToString();
                    SensorValue = computer.Hardware[i].Sensors[j].Value;

                    if (SensorType == "Power") {
                        PowerUsage.Add(SensorValue);    
                    }
                }
            }
          
            computer.Close();
            return;
        }

        private void Results()
        {
            Boolean sandbox = true;
            
            foreach(float? f in PowerUsage) {
                Console.WriteLine("-> " + f + " W");
                if (f != 0) { sandbox = false; }
            }

            Console.WriteLine("\nResults !");

            if(sandbox == true) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mehh, you launched me in a VM");
            } else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Huhu, For me you are not a VM (or perhaps :P)");
            }

            return;
        }

        static void Main(string[] args)
        {
            Console.Title = "Araragi - Anti VM Detection PoC";
            Console.WriteLine("*** Araragi - Anti VM Detection PoC ***\n");
            Console.WriteLine("Warning : This tool must be launched on Admin mode\n");

            Program p = new Program();
            p.InitHardware();
            p.GetPowerUsage();
            p.Results();

            Console.ResetColor();
            Console.WriteLine("\nPress a key to quit");
            Console.ReadLine();
        }
    }
}
