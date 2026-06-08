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
   public class subwconsastro07 : GXSubfileElement
   {
      private int AstCodigo ;
      private String AstNome ;
      private DateTime AstDatFalecimento ;
      public int getAstCodigo( )
      {
         return AstCodigo ;
      }

      public void setAstCodigo( int value )
      {
         AstCodigo = value;
      }

      public String getAstNome( )
      {
         return AstNome ;
      }

      public void setAstNome( String value )
      {
         AstNome = value;
      }

      public DateTime getAstDatFalecimento( )
      {
         return AstDatFalecimento ;
      }

      public void setAstDatFalecimento( DateTime value )
      {
         AstDatFalecimento = value;
      }

      public override void clear( )
      {
         AstCodigo = 0 ;
         AstNome = "" ;
         AstDatFalecimento = DateTime.MinValue ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getAstCodigo() > ((subwconsastro07) element).getAstCodigo() ) return 1;
                  if ( getAstCodigo() < ((subwconsastro07) element).getAstCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getAstNome().CompareTo(((subwconsastro07) element).getAstNome()) ;
               case 2 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getAstDatFalecimento()) , GxConvert.AnyDateToJDate(((subwconsastro07) element).getAstDatFalecimento()) );
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getAstCodigo() == 0 ) && ( String.CompareOrdinal(getAstNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getAstDatFalecimento() == DateTime.MinValue ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getAstCodigo() );
               break;
            case 1 :
               cell.setValue( getAstNome() );
               break;
            case 2 :
               cell.setValue( GxConvert.AnyDateToJDate(getAstDatFalecimento()) );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( (((GUIObjectInt) cell).getValue() == getAstCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getAstNome()) == 0) );
            case 2 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getAstDatFalecimento()))) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setAstCodigo(value.getIntValue());
                  break;
               case 1 :
                  setAstNome(value.getStringValue());
                  break;
               case 2 :
                  setAstDatFalecimento(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setAstCodigo(((subwconsastro07) element).getAstCodigo());
                  return;
               case 1 :
                  setAstNome(((subwconsastro07) element).getAstNome());
                  return;
               case 2 :
                  setAstDatFalecimento(((subwconsastro07) element).getAstDatFalecimento());
                  return;
         }
      }

   }

}
