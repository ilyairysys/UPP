
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �������������������������������
	{
		������������ = - 1,
		���������� = 0,//�� ��������
		������������ = 1,//� �����������
		�������������� = 2,//���������� ����
	}
	public static partial class �������������������������������_��������//:������������������
	{
		public static readonly Guid ���������� = new Guid("3cfbbd82-6397-a8d0-4973-e42b217057d3");//�� ��������
		public static readonly Guid ������������ = new Guid("3ab2e083-71f9-a333-4ab1-889cdaf80e2c");//� �����������
		public static readonly Guid �������������� = new Guid("335179af-7fe5-922b-41db-8c830ee12f80");//���������� ����
		public static ������������������������������� ��������(this ������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������������� ��������(this ������������������������������� ��������, Guid ������)
		{
			if(������ == ����������)
			{
				return �������������������������������.����������;
			}
			else if(������ == ������������)
			{
				return �������������������������������.������������;
			}
			else if(������ == ��������������)
			{
				return �������������������������������.��������������;
			}
			return �������������������������������.������������;
		}
		public static byte[] ����(this ������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������������� ��������)
		{
			switch (��������)
			{
				case �������������������������������.����������: return ����������;
				case �������������������������������.������������: return ������������;
				case �������������������������������.��������������: return ��������������;
			}
			return Guid.Empty;
		}
	}
}
