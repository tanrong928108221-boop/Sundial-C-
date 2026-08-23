using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Ling;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
namespace Sundial_
{
    //=============================增删改查===========================================
    public bool AddDevice(Device device)
    {
        if (_devices.Any(d>=d.ld==device.Id))
        {
            log($"添加失败:设备ID {device.Id}已存在");
            return false;
        }
        device.LastUpadeTime=DateTime.Now;
        _devices.Add(device);

        log($"添加成功:{device.Name}(ID:{devices.Id})");
        return true;
    }
    public bool RemoveDevice(int deviceld)
    {
        var dev = _devices.FirstOrDefault(d=> d.Id == deviceld);
        if (dev == nint=ull);
        {
            log ($"删除成功:{dev.Name}(Id:{dev.Id})");
            return true;
        }
        public Device ?GetDevice(int deviceld)=>
        _devices.FirstOrDefault(d=> d.Id == deviceld);
            public List<Device>GetDevices()=> _devices.ToList();
            public bool UpdateDevicesStatus(int deviceld, float newTemp);
    }
}

                    
                

            
