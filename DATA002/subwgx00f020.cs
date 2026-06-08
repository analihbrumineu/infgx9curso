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
   public class subwgx00f020 : GXSubfileElement
   {
      private int LocCodigo ;
      private short LocSituacao ;
      private String LocSituacaoDescription ;
      private DateTime LocDatLocacao ;
      public int getLocCodigo( )
      {
         return LocCodigo ;
      }

      public void setLocCodigo( int value )
      {
         LocCodigo = value;
      }

      public short getLocSituacao( )
      {
         return LocSituacao ;
      }

      public void setLocSituacao( short value )
      {
         LocSituacao = value;
      }

      public String getLocSituacaoDescription( )
      {
         return LocSituacaoDescription ;
      }

      public void setLocSituacaoDescription( String value )
      {
         LocSituacaoDescription = value;
      }

      public DateTime getLocDatLocacao( )
      {
         return LocDatLocacao ;
      }

      public void setLocDatLocacao( DateTime value )
      {
         LocDatLocacao = value;
      }

      public override void clear( )
      {
         LocCodigo = 0 ;
         LocSituacao = 0 ;
         LocDatLocacao = DateTime.MinValue ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getLocCodigo() > ((subwgx00f020) element).getLocCodigo() ) return 1;
                  if ( getLocCodigo() < ((subwgx00f020) element).getLocCodigo() ) return -1;
                  return 0;
               case 1 :
                  if ( getLocSituacao() > ((subwgx00f020) element).getLocSituacao() ) return 1;
                  if ( getLocSituacao() < ((subwgx00f020) element).getLocSituacao() ) return -1;
                  return 0;
               case 2 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getLocDatLocacao()) , GxConvert.AnyDateToJDate(((subwgx00f020) element).getLocDatLocacao()) );
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getLocCodigo() == 0 ) && ( getLocSituacao() == 0 ) && ( getLocDatLocacao() == DateTime.MinValue ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getLocCodigo() );
               break;
            case 1 :
               cell.setValue( getLocSituacao() );
               break;
            case 2 :
               cell.setValue( GxConvert.AnyDateToJDate(getLocDatLocacao()) );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 1 :
               return getLocSituacaoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( (((GUIObjectInt) cell).getValue() == getLocCodigo()) );
            case 1 :
               return ( (((GUIObjectShort) cell).getValue() == getLocSituacao()) );
            case 2 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getLocDatLocacao()))) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setLocCodigo(value.getIntValue());
                  break;
               case 1 :
                  setLocSituacao(value.getShortValue());
                  setLocSituacaoDescription( value.getText());
                  break;
               case 2 :
                  setLocDatLocacao(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setLocCodigo(((subwgx00f020) element).getLocCodigo());
                  return;
               case 1 :
                  setLocSituacao(((subwgx00f020) element).getLocSituacao());
                  setLocSituacaoDescription(((subwgx00f020) element).getLocSituacaoDescription());
                  return;
               case 2 :
                  setLocDatLocacao(((subwgx00f020) element).getLocDatLocacao());
                  return;
         }
      }

   }

}
