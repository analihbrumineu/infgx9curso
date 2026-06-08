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
   public class subwpemidia02 : GXSubfileElement
   {
      private String VVisualizar ;
      private String VEditar ;
      private String VExcluir ;
      private int MidCodigo ;
      private short MidTipo ;
      private String MidTipoDescription ;
      private short MidSituacao ;
      private String MidSituacaoDescription ;
      private int FilCodigo ;
      private String FilNome ;
      private DateTime FilData ;
      private decimal ConfTipValor ;
      public String getVVisualizar( )
      {
         return VVisualizar ;
      }

      public void setVVisualizar( String value )
      {
         VVisualizar = value;
      }

      public String getVEditar( )
      {
         return VEditar ;
      }

      public void setVEditar( String value )
      {
         VEditar = value;
      }

      public String getVExcluir( )
      {
         return VExcluir ;
      }

      public void setVExcluir( String value )
      {
         VExcluir = value;
      }

      public int getMidCodigo( )
      {
         return MidCodigo ;
      }

      public void setMidCodigo( int value )
      {
         MidCodigo = value;
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

      public short getMidSituacao( )
      {
         return MidSituacao ;
      }

      public void setMidSituacao( short value )
      {
         MidSituacao = value;
      }

      public String getMidSituacaoDescription( )
      {
         return MidSituacaoDescription ;
      }

      public void setMidSituacaoDescription( String value )
      {
         MidSituacaoDescription = value;
      }

      public int getFilCodigo( )
      {
         return FilCodigo ;
      }

      public void setFilCodigo( int value )
      {
         FilCodigo = value;
      }

      public String getFilNome( )
      {
         return FilNome ;
      }

      public void setFilNome( String value )
      {
         FilNome = value;
      }

      public DateTime getFilData( )
      {
         return FilData ;
      }

      public void setFilData( DateTime value )
      {
         FilData = value;
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
         VVisualizar = "" ;
         VEditar = "" ;
         VExcluir = "" ;
         MidCodigo = 0 ;
         MidTipo = 0 ;
         MidSituacao = 0 ;
         FilCodigo = 0 ;
         FilNome = "" ;
         FilData = DateTime.MinValue ;
         ConfTipValor = 0M ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  return  getVVisualizar().CompareTo(((subwpemidia02) element).getVVisualizar()) ;
               case 1 :
                  return  getVEditar().CompareTo(((subwpemidia02) element).getVEditar()) ;
               case 2 :
                  return  getVExcluir().CompareTo(((subwpemidia02) element).getVExcluir()) ;
               case 3 :
                  if ( getMidCodigo() > ((subwpemidia02) element).getMidCodigo() ) return 1;
                  if ( getMidCodigo() < ((subwpemidia02) element).getMidCodigo() ) return -1;
                  return 0;
               case 4 :
                  if ( getMidTipo() > ((subwpemidia02) element).getMidTipo() ) return 1;
                  if ( getMidTipo() < ((subwpemidia02) element).getMidTipo() ) return -1;
                  return 0;
               case 5 :
                  if ( getMidSituacao() > ((subwpemidia02) element).getMidSituacao() ) return 1;
                  if ( getMidSituacao() < ((subwpemidia02) element).getMidSituacao() ) return -1;
                  return 0;
               case 6 :
                  if ( getFilCodigo() > ((subwpemidia02) element).getFilCodigo() ) return 1;
                  if ( getFilCodigo() < ((subwpemidia02) element).getFilCodigo() ) return -1;
                  return 0;
               case 7 :
                  return  getFilNome().CompareTo(((subwpemidia02) element).getFilNome()) ;
               case 8 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getFilData()) , GxConvert.AnyDateToJDate(((subwpemidia02) element).getFilData()) );
               case 9 :
                  if ( getConfTipValor() > ((subwpemidia02) element).getConfTipValor() ) return 1;
                  if ( getConfTipValor() < ((subwpemidia02) element).getConfTipValor() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( String.CompareOrdinal(getVVisualizar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVEditar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVExcluir().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getMidCodigo() == 0 ) && ( getMidTipo() == 0 ) && ( getMidSituacao() == 0 ) && ( getFilCodigo() == 0 ) && ( String.CompareOrdinal(getFilNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getFilData() == DateTime.MinValue ) && ( getConfTipValor() == Convert.ToDecimal( 0M )) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getVVisualizar() );
               break;
            case 1 :
               cell.setValue( getVEditar() );
               break;
            case 2 :
               cell.setValue( getVExcluir() );
               break;
            case 3 :
               cell.setValue( getMidCodigo() );
               break;
            case 4 :
               cell.setValue( getMidTipo() );
               break;
            case 5 :
               cell.setValue( getMidSituacao() );
               break;
            case 6 :
               cell.setValue( getFilCodigo() );
               break;
            case 7 :
               cell.setValue( getFilNome() );
               break;
            case 8 :
               cell.setValue( GxConvert.AnyDateToJDate(getFilData()) );
               break;
            case 9 :
               cell.setValue( GxConvert.AnyDecimalToJDecimal(getConfTipValor()) );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 4 :
               return getMidTipoDescription() ;
            case 5 :
               return getMidSituacaoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVVisualizar()) == 0) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVEditar()) == 0) );
            case 2 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVExcluir()) == 0) );
            case 3 :
               return ( (((GUIObjectInt) cell).getValue() == getMidCodigo()) );
            case 4 :
               return ( (((GUIObjectShort) cell).getValue() == getMidTipo()) );
            case 5 :
               return ( (((GUIObjectShort) cell).getValue() == getMidSituacao()) );
            case 6 :
               return ( (((GUIObjectInt) cell).getValue() == getFilCodigo()) );
            case 7 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getFilNome()) == 0) );
            case 8 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getFilData()))) );
            case 9 :
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
                  break;
               case 1 :
                  break;
               case 2 :
                  break;
               case 3 :
                  setMidCodigo(value.getIntValue());
                  break;
               case 4 :
                  setMidTipo(value.getShortValue());
                  setMidTipoDescription( value.getText());
                  break;
               case 5 :
                  setMidSituacao(value.getShortValue());
                  setMidSituacaoDescription( value.getText());
                  break;
               case 6 :
                  setFilCodigo(value.getIntValue());
                  break;
               case 7 :
                  setFilNome(value.getStringValue());
                  break;
               case 8 :
                  setFilData(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
               case 9 :
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
                  setVVisualizar(((subwpemidia02) element).getVVisualizar());
                  return;
               case 1 :
                  setVEditar(((subwpemidia02) element).getVEditar());
                  return;
               case 2 :
                  setVExcluir(((subwpemidia02) element).getVExcluir());
                  return;
               case 3 :
                  setMidCodigo(((subwpemidia02) element).getMidCodigo());
                  return;
               case 4 :
                  setMidTipo(((subwpemidia02) element).getMidTipo());
                  setMidTipoDescription(((subwpemidia02) element).getMidTipoDescription());
                  return;
               case 5 :
                  setMidSituacao(((subwpemidia02) element).getMidSituacao());
                  setMidSituacaoDescription(((subwpemidia02) element).getMidSituacaoDescription());
                  return;
               case 6 :
                  setFilCodigo(((subwpemidia02) element).getFilCodigo());
                  return;
               case 7 :
                  setFilNome(((subwpemidia02) element).getFilNome());
                  return;
               case 8 :
                  setFilData(((subwpemidia02) element).getFilData());
                  return;
               case 9 :
                  setConfTipValor(((subwpemidia02) element).getConfTipValor());
                  return;
         }
      }

   }

}
