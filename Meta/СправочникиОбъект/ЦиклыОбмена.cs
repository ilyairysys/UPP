
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	public partial class �����������:����������������
	{
		public bool _��������;
		public bool ��������()
		{
			return _��������;
		}
		public Guid ������;
		public long ������;
		/*static ��� ����� ������� � ������� ����������*/
		/*������ ������ ���������������� �� ������*/
		public bool ���������������;
		public bool ����������������;
		public Guid ��������;
		public bool ���������;
		public Guid ��������;
		public string/*10*/ ���;
		public string/*150*/ ������������;
		public V82.�����������������.����������������������������� �������������;//������� ������
		public V82.������������/*������*/.���������������� ���;
		public string/*(100)*/ �������������;//������������� ����� ������
		public object �������;
		public V82.�����������������.����������� �����������;
		public object ������������������;//������� �����������
		public DateTime ������������;//���� ��������
		public DateTime ������������;//���� ��������
		public DateTime �����������������������;//���� ���������� ���������
		public object ���������;//��� ������
		public DateTime �����������������;//���� ������ �������
		public DateTime ��������������������;//���� ��������� �������
		public decimal/*(3)*/ ������������;//��� ���������
		public V82.������������/*������*/.��������������� ���������;//��� ������
		public V82.������������/*������*/.����������������������� ������������;//������ ������
		public string/*(16)*/ ������;
		public V82.������������/*������*/.���������������� ���;
		public V82.������������/*������*/.��������������������������� ����������������������;//������ ����������������
		public void ��������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					if(_��������)
					{
						�������.CommandText = @"
						Insert Into _Reference291(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld4228RRef
						,_Fld4229RRef
						,_Fld4230
						,_Fld4231RRef
						,_Fld4232RRef
						,_Fld4233RRef
						,_Fld4234
						,_Fld4235
						,_Fld4236
						,_Fld4237RRef
						,_Fld4238
						,_Fld4239
						,_Fld4240
						,_Fld4241RRef
						,_Fld4242RRef
						,_Fld4243
						,_Fld4244RRef
						,_Fld4245RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@�������������
						,@���
						,@�������������
						,@�������
						,@�����������
						,@������������������
						,@������������
						,@������������
						,@�����������������������
						,@���������
						,@�����������������
						,@��������������������
						,@������������
						,@���������
						,@������������
						,@������
						,@���
						,@����������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference291
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld4228RRef	= @�������������
						,_Fld4229RRef	= @���
						,_Fld4230	= @�������������
						,_Fld4231RRef	= @�������
						,_Fld4232RRef	= @�����������
						,_Fld4233RRef	= @������������������
						,_Fld4234	= @������������
						,_Fld4235	= @������������
						,_Fld4236	= @�����������������������
						,_Fld4237RRef	= @���������
						,_Fld4238	= @�����������������
						,_Fld4239	= @��������������������
						,_Fld4240	= @������������
						,_Fld4241RRef	= @���������
						,_Fld4242RRef	= @������������
						,_Fld4243	= @������
						,_Fld4244RRef	= @���
						,_Fld4245RRef	= @����������������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�������������", �������������.������);
					�������.Parameters.AddWithValue("���", ���.����());
					�������.Parameters.AddWithValue("�������������", �������������);
					�������.Parameters.AddWithValue("�������", �������.������);
					�������.Parameters.AddWithValue("�����������", �����������.������);
					�������.Parameters.AddWithValue("������������������", ������������������.������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�����������������������", �����������������������);
					�������.Parameters.AddWithValue("���������", ���������.������);
					�������.Parameters.AddWithValue("�����������������", �����������������);
					�������.Parameters.AddWithValue("��������������������", ��������������������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("���������", ���������.����());
					�������.Parameters.AddWithValue("������������", ������������.����());
					�������.Parameters.AddWithValue("������", ������);
					�������.Parameters.AddWithValue("���", ���.����());
					�������.Parameters.AddWithValue("����������������������", ����������������������.����());
					�������.ExecuteNonQuery();
				}
			}
		}
		public void �������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Delete _Reference291
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/

		public void ������������(/*�����*/)
		{
			if(true/*������������.��������*/)
			{
			}
			if(true/*����������� <> ������������*/)
			{
				/*�����������.�������������������(����������, �����);*/
			}
			/*#���������;*/
		}

		public void ���������(/*�����*/)
		{
			if(true/*������������.��������*/)
			{
			}
			if(true/*����������� <> ������������*/)
			{
				/*�����������.����������������(����������, �����);*/
			}
			/*#���������;*/
		}

		public void �������������������(/*������������������*/)
		{
			if(true/*����������� <> ������������*/)
			{
				/*�����������.��������������������������(����������, ������������������);*/
			}
			/*#���������;*/
		}
	}
}
