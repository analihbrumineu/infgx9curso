using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using com.genexus;
using com.genexus.ui;
using com.genexus.uifactory;
using GeneXus.Windows;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus.distributed;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class subwgx003008 : GXSubfileElement
   {
      private int FilCodigo ;
      private short FilSituacao ;
      private String FilSituacaoDescription ;
      private DateTime FilData ;
      public int getFilCodigo( )
      {
         return FilCodigo ;
      }

      public void setFilCodigo( int value )
      {
         FilCodigo = value;
      }

      public short getFilSituacao( )
      {
         return FilSituacao ;
      }

      public void setFilSituacao( short value )
      {
         FilSituacao = value;
      }

      public String getFilSituacaoDescription( )
      {
         return FilSituacaoDescription ;
      }

      public void setFilSituacaoDescription( String value )
      {
         FilSituacaoDescription = value;
      }

      public DateTime getFilData( )
      {
         return FilData ;
      }

      public void setFilData( DateTime value )
      {
         FilData = value;
      }

      public override void clear( )
      {
         FilCodigo = 0 ;
         FilSituacao = 0 ;
         FilData = DateTime.MinValue ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getFilCodigo() > ((subwgx003008) element).getFilCodigo() ) return 1;
                  if ( getFilCodigo() < ((subwgx003008) element).getFilCodigo() ) return -1;
                  return 0;
               case 1 :
                  if ( getFilSituacao() > ((subwgx003008) element).getFilSituacao() ) return 1;
                  if ( getFilSituacao() < ((subwgx003008) element).getFilSituacao() ) return -1;
                  return 0;
               case 2 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getFilData()) , GxConvert.AnyDateToJDate(((subwgx003008) element).getFilData()) );
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getFilCodigo() == 0 ) && ( getFilSituacao() == 0 ) && ( getFilData() == DateTime.MinValue ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getFilCodigo() );
               break;
            case 1 :
               cell.setValue( getFilSituacao() );
               break;
            case 2 :
               cell.setValue( GxConvert.AnyDateToJDate(getFilData()) );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 1 :
               return getFilSituacaoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( (((GUIObjectInt) cell).getValue() == getFilCodigo()) );
            case 1 :
               return ( (((GUIObjectShort) cell).getValue() == getFilSituacao()) );
            case 2 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getFilData()))) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setFilCodigo(value.getIntValue());
                  break;
               case 1 :
                  setFilSituacao(value.getShortValue());
                  setFilSituacaoDescription( value.getText());
                  break;
               case 2 :
                  setFilData(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setFilCodigo(((subwgx003008) element).getFilCodigo());
                  return;
               case 1 :
                  setFilSituacao(((subwgx003008) element).getFilSituacao());
                  setFilSituacaoDescription(((subwgx003008) element).getFilSituacaoDescription());
                  return;
               case 2 :
                  setFilData(((subwgx003008) element).getFilData());
                  return;
         }
      }

   }

}
