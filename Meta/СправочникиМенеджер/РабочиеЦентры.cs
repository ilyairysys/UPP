
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������;//��������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������//��������
{
	///<summary>
	///(���)
	///</summary>
	public partial class �������������:������������������
	{

		public static �����������������.������������� �����������(decimal ���)
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Select top 1 
					_IDRRef [������]
					,_Version [������]
					,_Marked [���������������]
					,_IsMetadata [����������������]
					,_Code [���]
					,_Description [������������]
					,_Fld3324RRef [�������������]
					,_Fld3325 [��������]
					,_Fld3326 [������������������������������������������]
					From _Reference214(NOLOCK)
					Where _Code=@���";
					�������.Parameters.AddWithValue("���", ���);
					using (var ������� = �������.ExecuteReader())
					{
						if (�������.Read())
						{
							var ������ = new �����������������.�������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							//������.������������� = new V82.�����������������.�������������((byte[])�������.GetValue(6));
							������.�������� = �������.GetString(7);
							������.������������������������������������������ = ((byte[])�������.GetValue(8))[0]==1?true:false;
							return ������;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}

		public static ������������������.������������� �������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Select top 1000 
					_IDRRef [������]
					,_Version [������]
					,_Marked [���������������]
					,_IsMetadata [����������������]
					,_Code [���]
					,_Description [������������],_Fld3324RRef [�������������],_Fld3325 [��������],_Fld3326 [������������������������������������������]
		 From _Reference214(NOLOCK)";
					var ������� = new V82.������������������.�������������();
					using (var ������� = �������.ExecuteReader())
					{
						while (�������.Read())
						{
							var ������ = new �����������������.�������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							//������.������������� = new V82.�����������������.�������������((byte[])�������.GetValue(6));
							������.�������� = �������.GetString(7);
							������.������������������������������������������ = ((byte[])�������.GetValue(8))[0]==1?true:false;
							�������.Add(������);
						}
							return �������;
					}
				}
			}
		}

		public static V82.�����������������.������������� ��������������()
		{
			var ������ = new V82.�����������������.�������������();
			������._�������� = true;
			������.������ = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			������.��������� = false;
			������.�������� = "";
			������.������������� = new V82.�����������������.�������������();
			return ������;
		}
	}
}
