
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �����������������������������
	{
		������������ = - 1,
		������� = 0,
		������� = 1,
		������ = 2,
	}
	public static partial class �����������������������������_��������//:������������������
	{
		public static readonly Guid ������� = new Guid("91fe0283-568d-33ef-478c-a853140fc5ef");
		public static readonly Guid ������� = new Guid("12430787-465f-41cc-408b-9d70d2d4173c");
		public static readonly Guid ������ = new Guid("61e5c391-a6a1-8a18-459e-3926e5af2a6c");
		public static ����������������������������� ��������(this ����������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������������������� ��������(this ����������������������������� ��������, Guid ������)
		{
			if(������ == �������)
			{
				return �����������������������������.�������;
			}
			else if(������ == �������)
			{
				return �����������������������������.�������;
			}
			else if(������ == ������)
			{
				return �����������������������������.������;
			}
			return �����������������������������.������������;
		}
		public static byte[] ����(this ����������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������������������� ��������)
		{
			switch (��������)
			{
				case �����������������������������.�������: return �������;
				case �����������������������������.�������: return �������;
				case �����������������������������.������: return ������;
			}
			return Guid.Empty;
		}
	}
}
