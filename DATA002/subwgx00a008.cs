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
   public class subwgx00a008 : GXSubfileElement
   {
      private int AstCodigo ;
      private DateTime AstDatNascimento ;
      public int getAstCodigo( )
      {
         return AstCodigo ;
      }

      public void setAstCodigo( int value )
      {
         AstCodigo = value;
      }

      public DateTime getAstDatNascimento( )
      {
         return AstDatNascimento ;
      }

      public void setAstDatNascimento( DateTime value )
      {
         AstDatNascimento = value;
      }

      public override void clear( )
      {
         AstCodigo = 0 ;
         AstDatNascimento = DateTime.MinValue ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getAstCodigo() > ((subwgx00a008) element).getAstCodigo() ) return 1;
                  if ( getAstCodigo() < ((subwgx00a008) element).getAstCodigo() ) return -1;
                  return 0;
               case 1 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getAstDatNascimento()) , GxConvert.AnyDateToJDate(((subwgx00a008) element).getAstDatNascimento()) );
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getAstCodigo() == 0 ) && ( getAstDatNascimento() == DateTime.MinValue ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getAstCodigo() );
               break;
            case 1 :
               cell.setValue( GxConvert.AnyDateToJDate(getAstDatNascimento()) );
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
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getAstDatNascimento()))) );
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
                  setAstDatNascimento(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setAstCodigo(((subwgx00a008) element).getAstCodigo());
                  return;
               case 1 :
                  setAstDatNascimento(((subwgx00a008) element).getAstDatNascimento());
                  return;
         }
      }

   }

}
