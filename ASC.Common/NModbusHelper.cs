using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modbus.Device;
using FtdAdapter;

namespace ASC.Common
{
    public class NModbusHelper:IModbusMaster
    {
        IModbusMaster m_ModbusMoster = null;

        /// <summary>
        /// Simple Modbus serial USB RTU master write multiple coils example.
        /// </summary>
        public static void ModbusSerialUsbRtuMasterWriteCoils()
        {
            using (FtdUsbPort port = new FtdUsbPort())
            {
                // configure usb port
                port.BaudRate = 19200;
                port.DataBits = 8;
                port.Parity = FtdParity.None;
                port.StopBits = FtdStopBits.One;
                port.OpenByIndex(0);

                // create modbus master
                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);

                byte slaveId = 1;
                ushort startAddress = 1;

                // write three coils
                master.WriteMultipleCoils(slaveId, startAddress, new bool[] { true, false, true });
            }
        }

        public ushort[] ReadHoldingRegisters(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            throw new NotImplementedException();
        }

        public ushort[] ReadInputRegisters(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            throw new NotImplementedException();
        }

        public bool[] ReadInputs(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            throw new NotImplementedException();
        }

        public ushort[] ReadWriteMultipleRegisters(byte slaveAddress, ushort startReadAddress, ushort numberOfPointsToRead, ushort startWriteAddress, ushort[] writeData)
        {
            throw new NotImplementedException();
        }

        public Modbus.IO.ModbusTransport Transport
        {
            get { throw new NotImplementedException(); }
        }

        public void WriteMultipleCoils(byte slaveAddress, ushort startAddress, bool[] data)
        {
            throw new NotImplementedException();
        }

        public void WriteMultipleRegisters(byte slaveAddress, ushort startAddress, ushort[] data)
        {
            throw new NotImplementedException();
        }

        public void WriteSingleCoil(byte slaveAddress, ushort coilAddress, bool value)
        {
            throw new NotImplementedException();
        }

        public void WriteSingleRegister(byte slaveAddress, ushort registerAddress, ushort value)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool[] ReadCoils(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            throw new NotImplementedException();
        }
    }
}
