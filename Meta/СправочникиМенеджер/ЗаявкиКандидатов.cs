
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
	public partial class ����������������:������������������
	{

		public static �����������������.���������������� �����������(decimal ���)
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
					,_Fld2325RRef [�������]
					,_Fld2326RRef [���������]
					,_Fld2327RRef [��������]
					,_Fld2328 [�����������]
					,_Fld2329 [�������]
					,_Fld2330 [�����������������]
					,_Fld2331RRef [������������]
					,_Fld2332 [������������]
					,_Fld2333RRef [������������������]
					,_Fld2334RRef [��������]
					,_Fld2335RRef [�������������]
					,_Fld2336RRef [���������]
					,_Fld2337RRef [�����������]
					,_Fld2338RRef [�������������]
					From _Reference100(NOLOCK)
					Where _Code=@���";
					�������.Parameters.AddWithValue("���", ���);
					using (var ������� = �������.ExecuteReader())
					{
						if (�������.Read())
						{
							var ������ = new �����������������.����������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							//������.������� = new V82.�����������������.��������������((byte[])�������.GetValue(6));
							//������.��������� = new V82.�����������������.�������������������������((byte[])�������.GetValue(7));
							������.�������� = V82.������������/*������*/.��������.������������.��������((byte[])�������.GetValue(8));
							������.����������� = �������.GetString(9);
							������.������� = ((byte[])�������.GetValue(10))[0]==1?true:false;
							������.����������������� = �������.GetString(11);
							//������.������������ = new V82.�����������������.����������������������((byte[])�������.GetValue(12));
							������.������������ = �������.GetDateTime(13);
							//������.������������������ = new V82.�����������������.�������������������((byte[])�������.GetValue(14));
							//������.�������� = new V82.�����������������.��������((byte[])�������.GetValue(15));
							//������.��������� = new V82.�����������������.���������((byte[])�������.GetValue(17));
							//������.����������� = new V82.�����������������.�����������((byte[])�������.GetValue(18));
							//������.������������� = new V82.�����������������.������������((byte[])�������.GetValue(19));
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

		public static ������������������.���������������� �������()
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
					,_Description [������������],_Fld2325RRef [�������],_Fld2326RRef [���������],_Fld2327RRef [��������],_Fld2328 [�����������],_Fld2329 [�������],_Fld2330 [�����������������],_Fld2331RRef [������������],_Fld2332 [������������],_Fld2333RRef [������������������],_Fld2334RRef [��������],_Fld2335RRef [�������������],_Fld2336RRef [���������],_Fld2337RRef [�����������],_Fld2338RRef [�������������]
		 From _Reference100(NOLOCK)";
					var ������� = new V82.������������������.����������������();
					using (var ������� = �������.ExecuteReader())
					{
						while (�������.Read())
						{
							var ������ = new �����������������.����������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							//������.������� = new V82.�����������������.��������������((byte[])�������.GetValue(6));
							//������.��������� = new V82.�����������������.�������������������������((byte[])�������.GetValue(7));
							������.�������� = V82.������������/*������*/.��������.������������.��������((byte[])�������.GetValue(8));
							������.����������� = �������.GetString(9);
							������.������� = ((byte[])�������.GetValue(10))[0]==1?true:false;
							������.����������������� = �������.GetString(11);
							//������.������������ = new V82.�����������������.����������������������((byte[])�������.GetValue(12));
							������.������������ = �������.GetDateTime(13);
							//������.������������������ = new V82.�����������������.�������������������((byte[])�������.GetValue(14));
							//������.�������� = new V82.�����������������.��������((byte[])�������.GetValue(15));
							//������.��������� = new V82.�����������������.���������((byte[])�������.GetValue(17));
							//������.����������� = new V82.�����������������.�����������((byte[])�������.GetValue(18));
							//������.������������� = new V82.�����������������.������������((byte[])�������.GetValue(19));
							�������.Add(������);
						}
							return �������;
					}
				}
			}
		}

		public static V82.�����������������.���������������� ��������������()
		{
			var ������ = new V82.�����������������.����������������();
			������._�������� = true;
			������.������ = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			������.��������� = false;
			������.����������� = "";
			������.����������������� = "";
			������.������� = new V82.�����������������.��������������();
			������.��������� = new V82.�����������������.�������������������������();
			������.�������� = V82.������������/*������*/.��������.������������;
			������.������������ = new V82.�����������������.����������������������();
			������.������������������ = new V82.�����������������.�������������������();
			������.�������� = new V82.�����������������.��������();
			������.��������� = new V82.�����������������.���������();
			������.����������� = new V82.�����������������.�����������();
			������.������������� = new V82.�����������������.������������();
			return ������;
		}
	}
}
