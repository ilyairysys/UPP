
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum ������������������
	{
		������������ = - 1,
		����������������� = 0,//����� �������� ����
		���������������������� = 1,//��������������� �������
		������������������ = 2,//������ ������� �����
		���������� = 3,//������� ���
	}
	public static partial class ������������������_��������//:������������������
	{
		public static readonly Guid ����������������� = new Guid("c716a69b-5d37-10d7-4af0-e7d28bba8041");//����� �������� ����
		public static readonly Guid ���������������������� = new Guid("ea9bcfb0-d764-3b60-4347-03a2b99c820d");//��������������� �������
		public static readonly Guid ������������������ = new Guid("041f41be-dfb9-47c8-42a5-48eafea835f7");//������ ������� �����
		public static readonly Guid ���������� = new Guid("dd27c5ae-4aea-1061-4ef9-103ea562aa36");//������� ���
		public static ������������������ ��������(this ������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������ ��������(this ������������������ ��������, Guid ������)
		{
			if(������ == �����������������)
			{
				return ������������������.�����������������;
			}
			else if(������ == ����������������������)
			{
				return ������������������.����������������������;
			}
			else if(������ == ������������������)
			{
				return ������������������.������������������;
			}
			else if(������ == ����������)
			{
				return ������������������.����������;
			}
			return ������������������.������������;
		}
		public static byte[] ����(this ������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������ ��������)
		{
			switch (��������)
			{
				case ������������������.�����������������: return �����������������;
				case ������������������.����������������������: return ����������������������;
				case ������������������.������������������: return ������������������;
				case ������������������.����������: return ����������;
			}
			return Guid.Empty;
		}
	}
}
