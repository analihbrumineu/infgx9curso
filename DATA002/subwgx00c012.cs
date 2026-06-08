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
   public class subwgx00c012 : GXSubfileElement
   {
      private short MidTipo ;
      private String MidTipoDescription ;
      private int CatCodigo ;
      private decimal ConfTipValor ;
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

      public override void clear( )
      {
         MidTipo = 0 ;
         CatCodigo = 0 ;
         ConfTipValor = 0M ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getMidTipo() > ((subwgx00c012) element).getMidTipo() ) return 1;
                  if ( getMidTipo() < ((subwgx00c012) element).getMidTipo() ) return -1;
                  return 0;
               case 1 :
                  if ( getCatCodigo() > ((subwgx00c012) element).getCatCodigo() ) return 1;
                  if ( getCatCodigo() < ((subwgx00c012) element).getCatCodigo() ) return -1;
                  return 0;
               case 2 :
                  if ( getConfTipValor() > ((subwgx00c012) element).getConfTipValor() ) return 1;
                  if ( getConfTipValor() < ((subwgx00c012) element).getConfTipValor() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getMidTipo() == 0 ) && ( getCatCodigo() == 0 ) && ( getConfTipValor() == Convert.ToDecimal( 0M )) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getMidTipo() );
               break;
            case 1 :
               cell.setValue( getCatCodigo() );
               break;
            case 2 :
               cell.setValue( GxConvert.AnyDecimalToJDecimal(getConfTipValor()) );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 0 :
               return getMidTipoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( (((GUIObjectShort) cell).getValue() == getMidTipo()) );
            case 1 :
               return ( (((GUIObjectInt) cell).getValue() == getCatCodigo()) );
            case 2 :
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
                  setMidTipo(value.getShortValue());
                  setMidTipoDescription( value.getText());
                  break;
               case 1 :
                  setCatCodigo(value.getIntValue());
                  break;
               case 2 :
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
                  setMidTipo(((subwgx00c012) element).getMidTipo());
                  setMidTipoDescription(((subwgx00c012) element).getMidTipoDescription());
                  return;
               case 1 :
                  setCatCodigo(((subwgx00c012) element).getCatCodigo());
                  return;
               case 2 :
                  setConfTipValor(((subwgx00c012) element).getConfTipValor());
                  return;
         }
      }

   }

}
