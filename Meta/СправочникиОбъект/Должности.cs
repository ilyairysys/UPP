
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	///<summary>
	///(���)
	///</summary>
	public partial class ���������:����������������
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
		public string/*9*/ ���;
		public string/*100*/ ������������;
		public string/*(0)*/ ����������;
		public string/*(0)*/ �����������;
		public string/*(0)*/ �������;
		///<summary>
		///�������� �������� � ��������� �������� ����������
		///</summary>
		public string/*(200)*/ ���������������������������;//�������� �������� � ���
		public V82.�����������������.������������� ���������������������;//������ ������ ���������
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
						Insert Into _Reference91(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2270
						,_Fld2271
						,_Fld2272
						,_Fld2273
						,_Fld2274RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@����������
						,@�����������
						,@�������
						,@���������������������������
						,@���������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference91
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld2270	= @����������
						,_Fld2271	= @�����������
						,_Fld2272	= @�������
						,_Fld2273	= @���������������������������
						,_Fld2274RRef	= @���������������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("����������", ����������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("�������", �������);
					�������.Parameters.AddWithValue("���������������������������", ���������������������������);
					�������.Parameters.AddWithValue("���������������������", ���������������������.������);
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
					�������.CommandText = @"Delete _Reference91
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/

		public object ������(/*�������������� = ������������ ,��������� = ������������*/)
		{
			if(true/*��������� = ������������*/)
			{
				/*��������� = ����� �����������������;*/
			}
			/*���������.��������������  = ������;*/
			/*���������.��������������� = ����;*/
			/*���������.������������������� = ����;*/
			/*��������������������� = �������������("�����������������������������");*/
			/*// �������� ��������� ����� ���������� ������
*/
			/*��������� = ���������������������.��������������������;*/
			/*�������������.�������������(���������.�����, "���������", ������);*/
			/*// ������� �������������� ��������� ��������
*/
			/*//���������.����������� = ������;
*/
			/*���������.��������();*/
			/*// ������� ����� ���������� ������
*/
			/*����������������� = ����� ���������������������������������;*/
			/*���������������   = �����������������.���������(���������������������, ���������, );*/
			/*// �������� � �������������� ��������� ���������� ������
*/
			/*������������������� = ����� �������������������������;*/
			/*�������������������.����������������(���������������, , );*/
			/*// ������� ����� � ��������� �������� "���������"
*/
			/*����������������������������������(�������������������, ���������);*/
		}

		public void ����������������������������������(/*�������������������������, �����������������*/)
		{
			/*// �������� � �������������� ��������� ������ ����������
*/
			/*��������������� = ����� �����������������������������������������������������������;*/
			/*���������������.������������������(�����������������);*/
			/*// ��������� ������ ������
*/
			/*���������������.�����������();*/
			/*���������(����("ru='���� �� ������ �������� ����� ������, ������� Ctrl+Break'"));*/
			/*// �������� ���� ������ ������
*/
			while(true/*������*/)
			{
				/*// ������� ��������� ������� ���������� ����������
*/
				/*����������������� = �������������������������.���������();*/
				if(true/*����������������� = ������������*/)
				{
					/*// ��������� ������� �� ������� - ����������� ���� ������
*/
					/*��������;*/
				}
				/*�������������������������������();*/
			}
			/*;
	
	���������������.��������������();*/
		}
	}
}
