
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum ����������������������������������
	{
		������������ = - 1,
		������09 = 0,//9% (30%, 15%)
		������13 = 1,//13% (30%)
		������35 = 2,//35% (30%)
	}
	public static partial class ����������������������������������_��������//:������������������
	{
		public static readonly Guid ������09 = new Guid("bd6769b7-eaab-4629-405f-f21826110db6");//9% (30%, 15%)
		public static readonly Guid ������13 = new Guid("2c6114a6-6ecd-a793-486b-22974798ce86");//13% (30%)
		public static readonly Guid ������35 = new Guid("6dc62d92-9a0c-6946-4ae2-c04a341c20d6");//35% (30%)
		public static ���������������������������������� ��������(this ���������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������������������������� ��������(this ���������������������������������� ��������, Guid ������)
		{
			if(������ == ������09)
			{
				return ����������������������������������.������09;
			}
			else if(������ == ������13)
			{
				return ����������������������������������.������13;
			}
			else if(������ == ������35)
			{
				return ����������������������������������.������35;
			}
			return ����������������������������������.������������;
		}
		public static byte[] ����(this ���������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������������������������������� ��������)
		{
			switch (��������)
			{
				case ����������������������������������.������09: return ������09;
				case ����������������������������������.������13: return ������13;
				case ����������������������������������.������35: return ������35;
			}
			return Guid.Empty;
		}
	}
}
