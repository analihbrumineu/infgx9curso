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
   public class subwpefuncionario02 : GXSubfileElement
   {
      private String VVisualizar ;
      private String VEditar ;
      private String VExcluir ;
      private int PesCodigo ;
      private String PesNome ;
      private short PesFunCargo ;
      private String PesFunCargoDescription ;
      private DateTime PesFunDatAdmissao ;
      private short VDemitido ;
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

      public int getPesCodigo( )
      {
         return PesCodigo ;
      }

      public void setPesCodigo( int value )
      {
         PesCodigo = value;
      }

      public String getPesNome( )
      {
         return PesNome ;
      }

      public void setPesNome( String value )
      {
         PesNome = value;
      }

      public short getPesFunCargo( )
      {
         return PesFunCargo ;
      }

      public void setPesFunCargo( short value )
      {
         PesFunCargo = value;
      }

      public String getPesFunCargoDescription( )
      {
         return PesFunCargoDescription ;
      }

      public void setPesFunCargoDescription( String value )
      {
         PesFunCargoDescription = value;
      }

      public DateTime getPesFunDatAdmissao( )
      {
         return PesFunDatAdmissao ;
      }

      public void setPesFunDatAdmissao( DateTime value )
      {
         PesFunDatAdmissao = value;
      }

      public short getVDemitido( )
      {
         return VDemitido ;
      }

      public void setVDemitido( short value )
      {
         VDemitido = value;
      }

      public override void clear( )
      {
         VVisualizar = "" ;
         VEditar = "" ;
         VExcluir = "" ;
         PesCodigo = 0 ;
         PesNome = "" ;
         PesFunCargo = 0 ;
         PesFunDatAdmissao = DateTime.MinValue ;
         VDemitido = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  return  getVVisualizar().CompareTo(((subwpefuncionario02) element).getVVisualizar()) ;
               case 1 :
                  return  getVEditar().CompareTo(((subwpefuncionario02) element).getVEditar()) ;
               case 2 :
                  return  getVExcluir().CompareTo(((subwpefuncionario02) element).getVExcluir()) ;
               case 3 :
                  if ( getPesCodigo() > ((subwpefuncionario02) element).getPesCodigo() ) return 1;
                  if ( getPesCodigo() < ((subwpefuncionario02) element).getPesCodigo() ) return -1;
                  return 0;
               case 4 :
                  return  getPesNome().CompareTo(((subwpefuncionario02) element).getPesNome()) ;
               case 5 :
                  if ( getPesFunCargo() > ((subwpefuncionario02) element).getPesFunCargo() ) return 1;
                  if ( getPesFunCargo() < ((subwpefuncionario02) element).getPesFunCargo() ) return -1;
                  return 0;
               case 6 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getPesFunDatAdmissao()) , GxConvert.AnyDateToJDate(((subwpefuncionario02) element).getPesFunDatAdmissao()) );
               case 7 :
                  if ( getVDemitido() > ((subwpefuncionario02) element).getVDemitido() ) return 1;
                  if ( getVDemitido() < ((subwpefuncionario02) element).getVDemitido() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( String.CompareOrdinal(getVVisualizar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVEditar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVExcluir().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getPesCodigo() == 0 ) && ( String.CompareOrdinal(getPesNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getPesFunCargo() == 0 ) && ( getPesFunDatAdmissao() == DateTime.MinValue ) && ( getVDemitido() == 0 ) )  ;
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
               cell.setValue( getPesCodigo() );
               break;
            case 4 :
               cell.setValue( getPesNome() );
               break;
            case 5 :
               cell.setValue( getPesFunCargo() );
               break;
            case 6 :
               cell.setValue( GxConvert.AnyDateToJDate(getPesFunDatAdmissao()) );
               break;
            case 7 :
               cell.setValue( getVDemitido() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 5 :
               return getPesFunCargoDescription() ;
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
               return ( (((GUIObjectInt) cell).getValue() == getPesCodigo()) );
            case 4 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getPesNome()) == 0) );
            case 5 :
               return ( (((GUIObjectShort) cell).getValue() == getPesFunCargo()) );
            case 6 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getPesFunDatAdmissao()))) );
            case 7 :
               return ( (((GUIObjectShort) cell).getValue() == getVDemitido()) );
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
                  setPesCodigo(value.getIntValue());
                  break;
               case 4 :
                  setPesNome(value.getStringValue());
                  break;
               case 5 :
                  setPesFunCargo(value.getShortValue());
                  setPesFunCargoDescription( value.getText());
                  break;
               case 6 :
                  setPesFunDatAdmissao(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
               case 7 :
                  setVDemitido(value.getShortValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setVVisualizar(((subwpefuncionario02) element).getVVisualizar());
                  return;
               case 1 :
                  setVEditar(((subwpefuncionario02) element).getVEditar());
                  return;
               case 2 :
                  setVExcluir(((subwpefuncionario02) element).getVExcluir());
                  return;
               case 3 :
                  setPesCodigo(((subwpefuncionario02) element).getPesCodigo());
                  return;
               case 4 :
                  setPesNome(((subwpefuncionario02) element).getPesNome());
                  return;
               case 5 :
                  setPesFunCargo(((subwpefuncionario02) element).getPesFunCargo());
                  setPesFunCargoDescription(((subwpefuncionario02) element).getPesFunCargoDescription());
                  return;
               case 6 :
                  setPesFunDatAdmissao(((subwpefuncionario02) element).getPesFunDatAdmissao());
                  return;
               case 7 :
                  setVDemitido(((subwpefuncionario02) element).getVDemitido());
                  return;
         }
      }

   }

}
