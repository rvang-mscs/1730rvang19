using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rvang1730ex2C
{
    public partial class rvang1730ex2C : Form
    {
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;

        private void BtnMultiply_Click(object sender, EventArgs e)
        {

            try
            {
                this.byte3 = Convert.ToByte(this.byte1 * this.byte2);
                byte3TextBox.Text = byte3.ToString();
            }
            catch (Exception) { byte3TextBox.Text = "Error"; byte3 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 * this.sbyte2);
                sbyte3TextBox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3TextBox.Text = "Error"; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 * this.short2);
                short3TextBox.Text = short3.ToString();
            }
            catch (Exception) { short3TextBox.Text = "Error"; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 * this.ushort2);
                ushort3TextBox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3TextBox.Text = "Error"; }

            try
            {
                this.int3 = checked(this.int1 * this.int2);
                int3TextBox.Text = int3.ToString();
            }
            catch (Exception) { int3TextBox.Text = "Error"; }

            try
            {
                this.uint3 = checked(this.uint1 * this.uint2);
                uint3TextBox.Text = uint3.ToString();
            }
            catch (Exception) { uint3TextBox.Text = "Error"; }

            try
            {
                this.long3 = checked(this.long1 * this.long2);
                long3TextBox.Text = long3.ToString();
            }
            catch (Exception) { long3TextBox.Text = "Error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 * this.ulong2);
                ulong3TextBox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3TextBox.Text = "Error"; }

            try
            {
                this.float3 = checked(this.float1 * this.float2);
                float3TextBox.Text = float3.ToString();
            }
            catch (Exception) { float3TextBox.Text = "Error"; }

            try
            {
                this.double3 = checked(this.double1 * this.double2);
                double3TextBox.Text = double3.ToString();
            }
            catch (Exception) { double3TextBox.Text = "Error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 * this.decimal2);
                decimal3TextBox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3TextBox.Text = "Error"; }

        }

        private void Btndivide_Click(object sender, EventArgs e)
        {

            try
            {
                this.byte3 = Convert.ToByte(this.byte1 / this.byte2);
                byte3TextBox.Text = byte3.ToString();
            }
            catch (Exception) { byte3TextBox.Text = "Error"; byte3 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 / this.sbyte2);
                sbyte3TextBox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3TextBox.Text = "Error"; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 / this.short2);
                short3TextBox.Text = short3.ToString();
            }
            catch (Exception) { short3TextBox.Text = "Error"; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 / this.ushort2);
                ushort3TextBox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3TextBox.Text = "Error"; }

            try
            {
                this.int3 = checked(this.int1 / this.int2);
                int3TextBox.Text = int3.ToString();
            }
            catch (Exception) { int3TextBox.Text = "Error"; }

            try
            {
                this.uint3 = checked(this.uint1 / this.uint2);
                uint3TextBox.Text = uint3.ToString();
            }
            catch (Exception) { uint3TextBox.Text = "Error"; }

            try
            {
                this.long3 = checked(this.long1 / this.long2);
                long3TextBox.Text = long3.ToString();
            }
            catch (Exception) { long3TextBox.Text = "Error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 / this.ulong2);
                ulong3TextBox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3TextBox.Text = "Error"; }

            try
            {
                this.float3 = checked(this.float1 / this.float2);
                float3TextBox.Text = float3.ToString();
            }
            catch (Exception) { float3TextBox.Text = "Error"; }

            try
            {
                this.double3 = checked(this.double1 / this.double2);
                double3TextBox.Text = double3.ToString();
            }
            catch (Exception) { double3TextBox.Text = "Error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 / this.decimal2);
                decimal3TextBox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3TextBox.Text = "Error"; }

        }

        private void Btnsubract_Click(object sender, EventArgs e)
        {

            try
            {
                this.byte3 = Convert.ToByte(this.byte1 - this.byte2);
                byte3TextBox.Text = byte3.ToString();
            }
            catch (Exception) { byte3TextBox.Text = "Error"; byte3 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 - this.sbyte2);
                sbyte3TextBox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3TextBox.Text = "Error"; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 - this.short2);
                short3TextBox.Text = short3.ToString();
            }
            catch (Exception) { short3TextBox.Text = "Error"; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 - this.ushort2);
                ushort3TextBox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3TextBox.Text = "Error"; }

            try
            {
                this.int3 = checked(this.int1 - this.int2);
                int3TextBox.Text = int3.ToString();
            }
            catch (Exception) { int3TextBox.Text = "Error"; }

            try
            {
                this.uint3 = checked(this.uint1 - this.uint2);
                uint3TextBox.Text = uint3.ToString();
            }
            catch (Exception) { uint3TextBox.Text = "Error"; }

            try
            {
                this.long3 = checked(this.long1 - this.long2);
                long3TextBox.Text = long3.ToString();
            }
            catch (Exception) { long3TextBox.Text = "Error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 - this.ulong2);
                ulong3TextBox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3TextBox.Text = "Error"; }

            try
            {
                this.float3 = checked(this.float1 - this.float2);
                float3TextBox.Text = float3.ToString();
            }
            catch (Exception) { float3TextBox.Text = "Error"; }

            try
            {
                this.double3 = checked(this.double1 - this.double2);
                double3TextBox.Text = double3.ToString();
            }
            catch (Exception) { double3TextBox.Text = "Error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 - this.decimal2);
                decimal3TextBox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3TextBox.Text = "Error"; }

        }

        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;

        private void Btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 + this.byte2);
                byte3TextBox.Text = byte3.ToString();
            }
            catch (Exception) { byte3TextBox.Text = "Error"; byte3 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 + this.sbyte2);
                sbyte3TextBox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3TextBox.Text = "Error";}

            try
            {
                this.short3 = Convert.ToInt16(this.short1 + this.short2);
                short3TextBox.Text = short3.ToString();
            }
            catch (Exception) { short3TextBox.Text = "Error";}

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 + this.ushort2);
                ushort3TextBox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3TextBox.Text = "Error";}

            try
            {
                this.int3 = checked(this.int1 + this.int2);
                int3TextBox.Text = int3.ToString();
            }
            catch (Exception) { int3TextBox.Text = "Error"; }

            try
            {
                this.uint3 = checked(this.uint1 + this.uint2);
                uint3TextBox.Text = uint3.ToString();
            }
            catch (Exception) { uint3TextBox.Text = "Error"; }

            try
            {
                this.long3 = checked(this.long1 + this.long2);
                long3TextBox.Text = long3.ToString();
            }
            catch (Exception) { long3TextBox.Text = "Error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 + this.ulong2);
                ulong3TextBox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3TextBox.Text = "Error"; }

            try
            {
                this.float3 = checked(this.float1 + this.float2);
                float3TextBox.Text = float3.ToString();
            }
            catch (Exception) { float3TextBox.Text = "Error"; }

            try
            {
                this.double3 = checked(this.double1 + this.double2);
                double3TextBox.Text = double3.ToString();
            }
            catch (Exception) { double3TextBox.Text = "Error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 + this.decimal2);
                decimal3TextBox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3TextBox.Text = "Error";}

        }

        private void Input2TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(input2TextBox.Text);
                byte2TextBox.Text = byte2.ToString();
            }
            catch (Exception) { byte2TextBox.Text = "Error"; byte2 = 0; }

            try
            {
                sbyte2 = Convert.ToSByte(input2TextBox.Text);
                sbyte2TextBox.Text = sbyte2.ToString();
            }
            catch (Exception) { sbyte2TextBox.Text = "Error"; sbyte2 = 0; }

            try
            {
                short2 = Convert.ToInt16(input2TextBox.Text);
                short2TextBox.Text = short2.ToString();
            }
            catch (Exception) { short2TextBox.Text = "Error"; short2 = 0; }

            try
            {
                ushort2 = Convert.ToUInt16(input2TextBox.Text);
                ushort2TextBox.Text = ushort2.ToString();
            }
            catch (Exception) { ushort2TextBox.Text = "Error"; ushort2 = 0; }

            try
            {
                int2 = Convert.ToInt32(input2TextBox.Text);
                int2TextBox.Text = int2.ToString();
            }
            catch (Exception) { int2TextBox.Text = "Error"; int2 = 0; }

            try
            {
                uint2 = Convert.ToUInt32(input2TextBox.Text);
                uint2TextBox.Text = uint2.ToString();
            }
            catch (Exception) { uint2TextBox.Text = "Error"; uint2 = 0; }

            try
            {
                long2 = Convert.ToInt64(input2TextBox.Text);
                long2TextBox.Text = long2.ToString();
            }
            catch (Exception) { long2TextBox.Text = "Error"; long2 = 0; }

            try
            {
                ulong2 = Convert.ToUInt64(input2TextBox.Text);
                ulong2TextBox.Text = ulong2.ToString();
            }
            catch (Exception) { ulong2TextBox.Text = "Error"; ulong2 = 0; }

            try
            {
                float2 = Convert.ToSingle(input2TextBox.Text);
                float2TextBox.Text = float2.ToString();
            }
            catch (Exception) { float2TextBox.Text = "Error"; float2 = 0.0f; }

            try
            {
                double2 = Convert.ToDouble(input2TextBox.Text);
                double2TextBox.Text = double2.ToString();
            }
            catch (Exception) { double2TextBox.Text = "Error"; double2 = 0.0; }

            try
            {
                decimal2 = Convert.ToDecimal(input2TextBox.Text);
                decimal2TextBox.Text = decimal2.ToString();
            }
            catch (Exception) { decimal2TextBox.Text = "Error"; decimal2 = 0m; }
        }

        public rvang1730ex2C()
        {
            InitializeComponent();
        }

        private void SetMinbtn_Click(object sender, EventArgs e)
        {

            byte1 = Byte.MinValue; byte1TextBox.Text = byte1.ToString();
            sbyte1 = SByte.MinValue; sbyteTextBox.Text = sbyte1.ToString();
            short1 = Int16.MinValue; shortTextBox.Text = short1.ToString();
            ushort1 = UInt16.MinValue; ushortTextBox.Text = ushort1.ToString();
            int1 = Int32.MinValue; intTextBox.Text = int1.ToString();
            uint1 = UInt32.MinValue; uintTextBox.Text = uint1.ToString();
            long1 = Int64.MinValue; longTextBox.Text = long1.ToString();
            ulong1 = UInt64.MinValue; ulongTextBox.Text = ulong1.ToString();
            float1 = Single.MinValue; floatTextBox.Text = float1.ToString();
            double1 = Double.MinValue; doubleTextBox.Text = double1.ToString();
            decimal1 = Decimal.MinValue; decimalTextBox.Text = decimal1.ToString();
        }

        private void SetMaxbtn_Click(object sender, EventArgs e)
        {
            byte2 = Byte.MaxValue; byte2TextBox.Text = byte2.ToString();
            sbyte2 = SByte.MaxValue; sbyte2TextBox.Text = sbyte2.ToString();
            short2 = Int16.MaxValue; short2TextBox.Text = short2.ToString();
            ushort2 = UInt16.MaxValue; ushort2TextBox.Text = ushort2.ToString();
            int2 = Int32.MaxValue; int2TextBox.Text = int2.ToString();
            uint2 = UInt32.MaxValue; uint2TextBox.Text = uint2.ToString();
            long2 = Int64.MaxValue; long2TextBox.Text = long2.ToString();
            ulong2 = UInt64.MaxValue; ulong2TextBox.Text = ulong2.ToString();
            float2 = Single.MaxValue; float2TextBox.Text = float2.ToString();
            double2 = Double.MaxValue; double2TextBox.Text = double2.ToString();
            decimal2 = Decimal.MaxValue; decimal2TextBox.Text = decimal2.ToString();
        }

        private void Input1TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte1 = Convert.ToByte(input1TextBox.Text);
                byte1TextBox.Text = byte1.ToString();
            }
            catch (Exception) { byte1TextBox.Text = "Error"; byte1 = 0; }

            try
            {
                sbyte1 = Convert.ToSByte(input1TextBox.Text);
                sbyteTextBox.Text = sbyte1.ToString();
            }
            catch (Exception) { sbyteTextBox.Text = "Error"; sbyte1 = 0; }

            try
            {
                short1 = Convert.ToInt16(input1TextBox.Text);
                shortTextBox.Text = short1.ToString();
            }
            catch (Exception) { shortTextBox.Text = "Error"; short1 = 0; }

            try
            {
                ushort1 = Convert.ToUInt16(input1TextBox.Text);
                ushortTextBox.Text = ushort1.ToString();
            }
            catch (Exception) { ushortTextBox.Text = "Error"; ushort1 = 0; }

            try
            {
                int1 = Convert.ToInt32(input1TextBox.Text);
                intTextBox.Text = int1.ToString();
            }
            catch (Exception) { intTextBox.Text = "Error"; int1 = 0; }

            try
            {
                uint1 = Convert.ToUInt32(input1TextBox.Text);
               uintTextBox.Text = uint1.ToString();
            }
            catch (Exception) {uintTextBox.Text = "Error"; uint1 = 0; }

            try
            {
                long1 = Convert.ToInt64(input1TextBox.Text);
                longTextBox.Text = long1.ToString();
            }
            catch (Exception) { longTextBox.Text = "Error"; long1 = 0; }

            try
            {
                ulong1 = Convert.ToUInt64(input1TextBox.Text);
                ulongTextBox.Text = ulong1.ToString();
            }
            catch (Exception) {ulongTextBox.Text = "Error"; ulong1 = 0; }

            try
            {
                float1 = Convert.ToSingle(input1TextBox.Text);
                floatTextBox.Text = float1.ToString();
            }
            catch (Exception) {floatTextBox.Text = "Error"; float1 = 0.0f; }

            try
            {
                double1 = Convert.ToDouble(input1TextBox.Text);
                doubleTextBox.Text = double1.ToString();
            }
            catch (Exception) { doubleTextBox.Text = "Error"; double1 = 0.0; }

            try
            {
                decimal1 = Convert.ToDecimal(input1TextBox.Text);
                decimalTextBox.Text = decimal1.ToString();
            }
            catch (Exception) { decimalTextBox.Text = "Error"; decimal1 = 0m; }

        }
    }
}
