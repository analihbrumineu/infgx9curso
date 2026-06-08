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
   public class subwgx00c112 : GXSubfileElement
   {
      private int CatCodigo ;
      private decimal ConfTipValor ;
      private short MidTipo ;
      private String MidTipoDescription ;
      public int getCatCodigo( )
      {
         return CatCodigo ;
      }

      public void setCatCodigo( int value )
      {
         CatCodigo = value;
      }

      public decimal getConfTipValor( )
      {
         return ConfTipValor ;
      }

      public void setConfTipValor( decimal value )
      {
         ConfTipValor = value;
      }

      public short getMidTipo( )
      {
         return MidTipo ;
      }

      public void setMidTipo( short value )
      {
         MidTipo = value;
      }

      public String getMidTipoDescription( )
      {
         return MidTipoDescription ;
      }

      public void setMidTipoDescription( String value )
      {
         MidTipoDescription = value;
      }

      public override void clear( )
      {
         CatCodigo = 0 ;
         ConfTipValor = 0M ;
         MidTipo = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getCatCodigo() > ((subwgx00c112) element).getCatCodigo() ) return 1;
                  if ( getCatCodigo() < ((subwgx00c112) element).getCatCodigo() ) return -1;
                  return 0;
               case 1 :
                  if ( getConfTipValor() > ((subwgx00c112) element).getConfTipValor() ) return 1;
                  if ( getConfTipValor() < ((subwgx00c112) element).getConfTipValor() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getCatCodigo() == 0 ) && ( getConfTipValor() == Convert.ToDecimal( 0M )) && ( getMidTipo() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getCatCodigo() );
               break;
            case 1 :
               cell.setValue( GxConvert.AnyDecimalToJDecimal(getConfTipValor()) );
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
               return ( (((GUIObjectInt) cell).getValue() == getCatCodigo()) );
            case 1 :
               return ( (((GUIObjectDecimal2) cell).getValue() == getConfTipValor()) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setCatCodigo(value.getIntValue());
                  break;
               case 1 :
                  setConfTipValor(GxConvert.AnyDecimalToDecimal(value.getDecimalValue()));
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setCatCodigo(((subwgx00c112) element).getCatCodigo());
                  return;
               case 1 :
                  setConfTipValor(((subwgx00c112) element).getConfTipValor());
                  return;
         }
      }

   }

}
