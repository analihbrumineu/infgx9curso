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
   public class subwconftipmidia02 : GXSubfileElement
   {
      private int CatCodigo ;
      private String CatNome ;
      private short MidTipo ;
      private String MidTipoDescription ;
      private decimal VConfTipValor ;
      private decimal VConfTipValNovo ;
      private String VMarcado ;
      public int getCatCodigo( )
      {
         return CatCodigo ;
      }

      public void setCatCodigo( int value )
      {
         CatCodigo = value;
      }

      public String getCatNome( )
      {
         return CatNome ;
      }

      public void setCatNome( String value )
      {
         CatNome = value;
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

      public decimal getVConfTipValor( )
      {
         return VConfTipValor ;
      }

      public void setVConfTipValor( decimal value )
      {
         VConfTipValor = value;
      }

      public decimal getVConfTipValNovo( )
      {
         return VConfTipValNovo ;
      }

      public void setVConfTipValNovo( decimal value )
      {
         VConfTipValNovo = value;
      }

      public String getVMarcado( )
      {
         return VMarcado ;
      }

      public void setVMarcado( String value )
      {
         VMarcado = value;
      }

      public override void clear( )
      {
         CatCodigo = 0 ;
         CatNome = "" ;
         MidTipo = 0 ;
         VConfTipValor = 0M ;
         VConfTipValNovo = 0M ;
         VMarcado = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getCatCodigo() > ((subwconftipmidia02) element).getCatCodigo() ) return 1;
                  if ( getCatCodigo() < ((subwconftipmidia02) element).getCatCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getCatNome().CompareTo(((subwconftipmidia02) element).getCatNome()) ;
               case 2 :
                  if ( getMidTipo() > ((subwconftipmidia02) element).getMidTipo() ) return 1;
                  if ( getMidTipo() < ((subwconftipmidia02) element).getMidTipo() ) return -1;
                  return 0;
               case 3 :
                  if ( getVConfTipValor() > ((subwconftipmidia02) element).getVConfTipValor() ) return 1;
                  if ( getVConfTipValor() < ((subwconftipmidia02) element).getVConfTipValor() ) return -1;
                  return 0;
               case 4 :
                  if ( getVConfTipValNovo() > ((subwconftipmidia02) element).getVConfTipValNovo() ) return 1;
                  if ( getVConfTipValNovo() < ((subwconftipmidia02) element).getVConfTipValNovo() ) return -1;
                  return 0;
               case 5 :
                  return  getVMarcado().CompareTo(((subwconftipmidia02) element).getVMarcado()) ;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getCatCodigo() == 0 ) && ( String.CompareOrdinal(getCatNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getMidTipo() == 0 ) && ( getVConfTipValor() == Convert.ToDecimal( 0M )) && ( getVConfTipValNovo() == Convert.ToDecimal( 0M )) && ( String.CompareOrdinal(getVMarcado().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getCatCodigo() );
               break;
            case 1 :
               cell.setValue( getCatNome() );
               break;
            case 2 :
               cell.setValue( getMidTipo() );
               break;
            case 3 :
               cell.setValue( GxConvert.AnyDecimalToJDecimal(getVConfTipValor()) );
               break;
            case 4 :
               cell.setValue( GxConvert.AnyDecimalToJDecimal(getVConfTipValNovo()) );
               break;
            case 5 :
               cell.setValue( getVMarcado() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 2 :
               return getMidTipoDescription() ;
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
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getCatNome()) == 0) );
            case 2 :
               return ( (((GUIObjectShort) cell).getValue() == getMidTipo()) );
            case 3 :
               return ( (((GUIObjectDecimal2) cell).getValue() == getVConfTipValor()) );
            case 4 :
               return ( (((GUIObjectDecimal2) cell).getValue() == getVConfTipValNovo()) );
            case 5 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVMarcado()) == 0) );
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
                  setCatNome(value.getStringValue());
                  break;
               case 2 :
                  setMidTipo(value.getShortValue());
                  setMidTipoDescription( value.getText());
                  break;
               case 3 :
                  setVConfTipValor(GxConvert.AnyDecimalToDecimal(value.getDecimalValue()));
                  break;
               case 4 :
                  setVConfTipValNovo(GxConvert.AnyDecimalToDecimal(value.getDecimalValue()));
                  break;
               case 5 :
                  setVMarcado(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setCatCodigo(((subwconftipmidia02) element).getCatCodigo());
                  return;
               case 1 :
                  setCatNome(((subwconftipmidia02) element).getCatNome());
                  return;
               case 2 :
                  setMidTipo(((subwconftipmidia02) element).getMidTipo());
                  setMidTipoDescription(((subwconftipmidia02) element).getMidTipoDescription());
                  return;
               case 3 :
                  setVConfTipValor(((subwconftipmidia02) element).getVConfTipValor());
                  return;
               case 4 :
                  setVConfTipValNovo(((subwconftipmidia02) element).getVConfTipValNovo());
                  return;
               case 5 :
                  setVMarcado(((subwconftipmidia02) element).getVMarcado());
                  return;
         }
      }

   }

}
