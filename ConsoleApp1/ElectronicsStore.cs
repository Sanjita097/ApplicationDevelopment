using System;
using System.Collections.Generic;

class ElectronicsStore
{
    // list to maintain electronics device objects
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    // Add a device to the store
    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} added to the store.");
    }

    // Remove device from the store
    public void RemoveDevice(ElectronicDevice device)
    {
        if (devices.Remove(device))
        {
            Console.WriteLine($"{device.Brand} removed from the store.");
        }
        else
        {
            Console.WriteLine($"{device.Brand} not found in the store to remove.");
        }
    }

    // Display information of all devices
    public void ShowAllDeviceInfo()
    {
        Console.WriteLine("\n-----Available Devices in store-----");
        foreach (ElectronicDevice device in devices)
        {
            // call abstract method
            device.ShowInfo();

            if (device is Laptop laptop)
            {
                laptop.TrunOnBattery();
            }
            else if (device is SmartPhone smartPhone)
            {
                smartPhone.EnableCamera();
            }
            Console.WriteLine();
        }
    }
}