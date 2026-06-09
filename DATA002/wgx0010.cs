/*
               File: Gx0010
        Description: Lista de Seleção Cadastro de clientes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/9/2026 11:37:37.27
       Program type: Callable routine
          Main DBMS: sqlserver
*/
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
   public class wgx0010 : GXWorkpanel
   {
      public wgx0010( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wgx0010( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wgx0010( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Gx0010" ;
      }

      public override String getFrmTitle( )
      {
         return "Lista de Seleção Cadastro de clientes." ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return ApplicationUI.getDefaultMenuBar(this) ;
      }

      public override int getFrmTop( )
      {
         return 0 ;
      }

      public override int getFrmLeft( )
      {
         return 0 ;
      }

      public override int getFrmWidth( )
      {
         return 605 ;
      }

      public override int getFrmHeight( )
      {
         return 402 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WGx0010.htm";
      }

      public override int getFrmBackground( )
      {
         return UIFactory.getColor(15) ;
      }

      public override int getFrmForeground( )
      {
         return UIFactory.getColor(6) ;
      }

      public override bool isMainProgram( )
      {
         return IsMain;
      }

      public override bool isModal( )
      {
         return true ;
      }

      protected bool hasDBAccess( )
      {
         return true ;
      }

      public override int getRefreshTimeout( )
      {
         return 0 ;
      }

      public override bool getRefreshTimeoutAlways( )
      {
         return true ;
      }

      public override bool getPaintAfterStart( )
      {
         return true ;
      }

      public override int getBorderStyle( )
      {
         return 2 ;
      }

      public override bool getMaxButton( )
      {
         return true ;
      }

      public override bool getMinButton( )
      {
         return true ;
      }

      public override bool getCtrlBox( )
      {
         return true ;
      }

      public override bool getShowInTaskbar( )
      {
         return true ;
      }

      public override String getFormIcon( )
      {
         return "" ;
      }

      public override bool getAutocenter( )
      {
         return false ;
      }

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( out int aP0_pPesCodigo )
      {
         this.AV12pPesCo = 0 ;
         executePrivate();
         aP0_pPesCodigo=this.AV12pPesCo;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load20( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwgx001020 = new subwgx001020 ();
         lV6cPesCPF = StringUtil.PadR( StringUtil.RTrim( AV6cPesCPF), 14, "%") ;
         lV9cPesEnd = StringUtil.PadR( StringUtil.RTrim( AV9cPesEnd), 20, "%") ;
         lV10cPesTe = StringUtil.PadR( StringUtil.RTrim( AV10cPesTe), 13, "%") ;
         lV11cPesCe = StringUtil.PadR( StringUtil.RTrim( AV11cPesCe), 13, "%") ;
         /* Using cursor W00282 */
         pr_default.execute(0, new Object[] {AV5cPesCod, lV6cPesCPF, AV7cPesDat, AV8cCidCod, lV9cPesEnd, lV10cPesTe, lV11cPesCe});
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGrd_1.getSize() < 10000 ) ) )
         {
            A26CidCodi = W00282_A26CidCodi[0] ;
            n26CidCodi = W00282_n26CidCodi[0] ;
            A18PesEndN = W00282_A18PesEndN[0] ;
            n18PesEndN = W00282_n18PesEndN[0] ;
            A21PesTele = W00282_A21PesTele[0] ;
            n21PesTele = W00282_n21PesTele[0] ;
            A22PesCelu = W00282_A22PesCelu[0] ;
            n22PesCelu = W00282_n22PesCelu[0] ;
            A111PesDat = W00282_A111PesDat[0] ;
            n111PesDat = W00282_n111PesDat[0] ;
            A15PesCPF = W00282_A15PesCPF[0] ;
            n15PesCPF = W00282_n15PesCPF[0] ;
            A13PesCodi = W00282_A13PesCodi[0] ;
            /* Execute user event: E11V282 */
            E11V282 ();
            pr_default.readNext(0);
         }
         if ( subGrd_1.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class Gx0010_load20 : GXLoadProducer
      {
         wgx0010 _sf ;

         public Gx0010_load20( wgx0010 uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer20();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load20();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors20();
         }

      }

      public override void GXRefresh( )
      {
         ControlsToVariables();
         GXRefreshCommand();
      }

      protected void GXRefreshCommand( )
      {
         if ( ! gxIsRefreshing )
         {
            gxIsRefreshing = true ;
            ControlsToVariables();
            standAlone();
            VariablesToControls();
            subGrd_1.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow20( )
      {
         return true;
      }

      public void autoRefresh_flow20( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( (AV5cPesCod!=cV5cPesCod)||(String.CompareOrdinal(AV6cPesCPF.TrimEnd(' '), cV6cPesCPF.TrimEnd(' ') )!=0)||(AV7cPesDat!=cV7cPesDat)||(AV8cCidCod!=cV8cCidCod)||(String.CompareOrdinal(AV9cPesEnd.TrimEnd(' '), cV9cPesEnd.TrimEnd(' ') )!=0)||(String.CompareOrdinal(AV10cPesTe.TrimEnd(' '), cV10cPesTe.TrimEnd(' ') )!=0)||(String.CompareOrdinal(AV11cPesCe.TrimEnd(' '), cV11cPesCe.TrimEnd(' ') )!=0) ) || (!loadedFirstTime && ! isLoadAtStartup_flow20() )) {
            subfile.refresh();
            resetSubfileConditions_flow20() ;
         }
      }

      public bool getSearch_flow20( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow20( )
      {
         cV5cPesCod = AV5cPesCod ;
         cV6cPesCPF = AV6cPesCPF ;
         cV7cPesDat = AV7cPesDat ;
         cV8cCidCod = AV8cCidCod ;
         cV9cPesEnd = AV9cPesEnd ;
         cV10cPesTe = AV10cPesTe ;
         cV11cPesCe = AV11cPesCe ;
      }

      public void resetSearchConditions_flow20( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow20( )
      {
         return new subwgx001020 ();
      }

      public bool getSearch_flow20( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow20( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow20( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow20( )
      {
         GXRefreshCommand20 ();
      }

      public class Gx0010_flow20 : GXSubfileFlow
      {
         wgx0010 _sf ;

         public Gx0010_flow20( wgx0010 uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow20();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow20(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow20();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow20();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow20(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow20();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow20(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow20(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow20(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow20();
         }

      }

      protected void GXRefreshCommand20( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public override void GXEnter( )
      {
         /* Execute user event: E12V282 */
         E12V282 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V282( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV12pPesCo = A13PesCodi ;
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
         eventLevelResetContext();
      }

      public void loadToBuffer20( )
      {
         subwgx001020 oAux = subwgx001020 ;
         subwgx001020 = new subwgx001020 ();
         variablesToSubfile20 ();
         subGrd_1.addElement(subwgx001020);
         subwgx001020 = oAux;
      }

      private void E11V282( )
      {
         /* Load Routine */
         subGrd_1.loadCommand();
      }

      protected void closeCursors20( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 0 , 0 , 605 , 402 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCpescodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),224, 24, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 224 , 24 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5cPesCod" );
         ((GXEdit) edtavCpescodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCpescodigo.addFocusListener(this);
         edtavCpescodigo.getGXComponent().setHelpId("HLP_WGx0010.htm");
         edtavCpescpf = new GUIObjectString ( new GXEdit(14, "999.999.999-99", UIFactory.getFont( "Courier New", 0, 9),224, 48, 108, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 224 , 48 , 108 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6cPesCPF" );
         ((GXEdit) edtavCpescpf.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCpescpf.addFocusListener(this);
         edtavCpescpf.getGXComponent().setHelpId("HLP_WGx0010.htm");
         edtavCpesdatnascimento = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),224, 72, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 224 , 72 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7cPesDat" );
         ((GXEdit) edtavCpesdatnascimento.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCpesdatnascimento.addFocusListener(this);
         edtavCpesdatnascimento.getGXComponent().setHelpId("HLP_WGx0010.htm");
         edtavCcidcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),224, 96, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 224 , 96 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8cCidCod" );
         ((GXEdit) edtavCcidcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCcidcodigo.addFocusListener(this);
         edtavCcidcodigo.getGXComponent().setHelpId("HLP_WGx0010.htm");
         edtavCpesendnumero = new GUIObjectString ( new GXEdit(20, "@!", UIFactory.getFont( "Courier New", 0, 9),224, 120, 150, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 224 , 120 , 150 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9cPesEnd" );
         ((GXEdit) edtavCpesendnumero.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCpesendnumero.addFocusListener(this);
         edtavCpesendnumero.getGXComponent().setHelpId("HLP_WGx0010.htm");
         edtavCpestelefone = new GUIObjectString ( new GXEdit(13, "(99)9999-9999", UIFactory.getFont( "Courier New", 0, 9),224, 144, 101, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 224 , 144 , 101 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV10cPesTe" );
         ((GXEdit) edtavCpestelefone.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCpestelefone.addFocusListener(this);
         edtavCpestelefone.getGXComponent().setHelpId("HLP_WGx0010.htm");
         edtavCpescelular = new GUIObjectString ( new GXEdit(13, "(99)9999-9999", UIFactory.getFont( "Courier New", 0, 9),224, 168, 101, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 224 , 168 , 101 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV11cPesCe" );
         ((GXEdit) edtavCpescelular.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCpescelular.addFocusListener(this);
         edtavCpescelular.getGXComponent().setHelpId("HLP_WGx0010.htm");
         addSubfile ( subGrd_1  = new GXSubfile ( new Gx0010_load20(this), new Gx0010_flow20(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 111, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 110 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A13PesCodi" ), "Código da pessoa"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 110 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(14, "999.999.999-99", UIFactory.getFont( "Courier New", 0, 9),0, 0, 106, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 105 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A15PesCPF" ), "CPF da pessoa"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 105 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 185, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 184 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A111PesDat" ), "Data de nascimento da pessoa"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 184 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 9 , 18 , GXPanel1 , 21 , 192 , 458 , 193 ,  18 ));
         subGrd_1.addActionListener(this);
         subGrd_1.addFocusListener(this);
         subGrd_1.setSortOnClick(true);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  497 ,  24 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Confirmar");
         bttBtn_enter.addActionListener(this);
         bttBtn_cancel = UIFactory.getGXButton( GXPanel1 , "Fechar" ,  497 ,  52 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_cancel.setTooltip("Fechar");
         bttBtn_cancel.addActionListener(this);
         bttBtn_cancel.setFiresEvents(false);
         bttBtn_refresh = UIFactory.getGXButton( GXPanel1 , "Renovar" ,  497 ,  80 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_refresh.setTooltip("Renovar");
         bttBtn_refresh.addActionListener(this);
         bttBtn_refresh.setFiresEvents(false);
         bttBtn_help = UIFactory.getGXButton( GXPanel1 , "Ajuda" ,  497 ,  118 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_help.setTooltip("Ajuda");
         bttBtn_help.addActionListener(this);
         bttBtn_help.setFiresEvents(false);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Código da pessoa", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 24 , 102 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "CPF da pessoa", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 48 , 86 , 13 );
         lbllbl11 = UIFactory.getLabel(GXPanel1, "Data de nascimento da pessoa", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 72 , 176 , 13 );
         lbllbl13 = UIFactory.getLabel(GXPanel1, "Código da cidade da pessoa", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 96 , 162 , 13 );
         lbllbl15 = UIFactory.getLabel(GXPanel1, "Número de endereço da pessoa", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 120 , 181 , 13 );
         lbllbl17 = UIFactory.getLabel(GXPanel1, "Telefone residencial da pessoa", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 144 , 178 , 13 );
         lbllbl19 = UIFactory.getLabel(GXPanel1, "Telefone celular da pessoa", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 168 , 155 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCpescodigo ,
                   edtavCpescpf ,
                   edtavCpesdatnascimento ,
                   edtavCcidcodigo ,
                   edtavCpesendnumero ,
                   edtavCpestelefone ,
                   edtavCpescelular ,
                   subGrd_1 ,
                   bttBtn_enter ,
                   bttBtn_cancel ,
                   bttBtn_refresh ,
                   bttBtn_help
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGrd_1, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile20( )
      {
         subwgx001020.setPesCodigo(A13PesCodi);
         subwgx001020.setPesCPF(A15PesCPF);
         subwgx001020.setPesDatNascimento(A111PesDat);
      }

      protected void subfileToVariables20( )
      {
         A13PesCodi = subwgx001020.getPesCodigo();
         A15PesCPF = subwgx001020.getPesCPF();
         A111PesDat = subwgx001020.getPesDatNascimento();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavCpescodigo.setValue( AV5cPesCod );
         edtavCpescpf.setValue( AV6cPesCPF );
         edtavCpesdatnascimento.setValue( AV7cPesDat );
         edtavCcidcodigo.setValue( AV8cCidCod );
         edtavCpesendnumero.setValue( AV9cPesEnd );
         edtavCpestelefone.setValue( AV10cPesTe );
         edtavCpescelular.setValue( AV11cPesCe );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5cPesCod = (int)(edtavCpescodigo.getValue()) ;
         edtavCpescodigo.setValue(AV5cPesCod);
         AV6cPesCPF = (String)(edtavCpescpf.getValue()) ;
         edtavCpescpf.setValue(AV6cPesCPF);
         AV7cPesDat = (DateTime)(edtavCpesdatnascimento.getValue()) ;
         edtavCpesdatnascimento.setValue(AV7cPesDat);
         AV8cCidCod = (int)(edtavCcidcodigo.getValue()) ;
         edtavCcidcodigo.setValue(AV8cCidCod);
         AV9cPesEnd = (String)(edtavCpesendnumero.getValue()) ;
         edtavCpesendnumero.setValue(AV9cPesEnd);
         AV10cPesTe = (String)(edtavCpestelefone.getValue()) ;
         edtavCpestelefone.setValue(AV10cPesTe);
         AV11cPesCe = (String)(edtavCpescelular.getValue()) ;
         edtavCpescelular.setValue(AV11cPesCe);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGrd_1.inValidElement() )
         {
            subwgx001020 = ( subwgx001020 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx001020 = new subwgx001020 ();
         }
         subfileToVariables20 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile20 ();
         subGrd_1.refreshLineValue(subwgx001020);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd_1.inValidElement() )
         {
            subwgx001020 = ( subwgx001020 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx001020 = new subwgx001020 ();
         }
         subfileToVariables20 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttBtn_cancel.isEventSource(eventSource) ) {
            if (canCleanup())
               this.cleanup();

            return;
         }
         if ( bttBtn_refresh.isEventSource(eventSource) ) {
            GXRefresh();
            return;
         }
         if ( bttBtn_help.isEventSource(eventSource) ) {
            showHelp();
            return;
         }
         if ( bttBtn_enter.isEventSource(eventSource) ) {
            /* Execute user event: E12V282 */
            E12V282 ();
            return;
         }
         if ( subGrd_1.isEventSource(eventSource) ) {
            /* Execute user event: E12V282 */
            E12V282 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavCpescodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCpescodigo.getGXCursor() );
            return;
         }
         if ( edtavCpescpf.isEventSource(eventSource) ) {
            setGXCursor( edtavCpescpf.getGXCursor() );
            return;
         }
         if ( edtavCpesdatnascimento.isEventSource(eventSource) ) {
            setGXCursor( edtavCpesdatnascimento.getGXCursor() );
            return;
         }
         if ( edtavCcidcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCcidcodigo.getGXCursor() );
            return;
         }
         if ( edtavCpesendnumero.isEventSource(eventSource) ) {
            setGXCursor( edtavCpesendnumero.getGXCursor() );
            return;
         }
         if ( edtavCpestelefone.isEventSource(eventSource) ) {
            setGXCursor( edtavCpestelefone.getGXCursor() );
            return;
         }
         if ( edtavCpescelular.isEventSource(eventSource) ) {
            setGXCursor( edtavCpescelular.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtavCpescodigo.isEventSource(eventSource) ) {
            AV5cPesCod = edtavCpescodigo.getValue() ;
            return;
         }
         if ( edtavCpescpf.isEventSource(eventSource) ) {
            AV6cPesCPF = edtavCpescpf.getValue() ;
            return;
         }
         if ( edtavCpesdatnascimento.isEventSource(eventSource) ) {
            AV7cPesDat = edtavCpesdatnascimento.getValue() ;
            return;
         }
         if ( edtavCcidcodigo.isEventSource(eventSource) ) {
            AV8cCidCod = edtavCcidcodigo.getValue() ;
            return;
         }
         if ( edtavCpesendnumero.isEventSource(eventSource) ) {
            AV9cPesEnd = edtavCpesendnumero.getValue() ;
            return;
         }
         if ( edtavCpestelefone.isEventSource(eventSource) ) {
            AV10cPesTe = edtavCpestelefone.getValue() ;
            return;
         }
         if ( edtavCpescelular.isEventSource(eventSource) ) {
            AV11cPesCe = edtavCpescelular.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (triggerEventEnter(eventSource, keyCode)) {
            /* Execute user event: E12V282 */
            E12V282 ();
            return true ;
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public override IGXButton getCancelButton( )
      {
         return bttBtn_cancel ;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
         }
         this.AV12pPesCo = AV12pPesCo;
         stopThreads();
         CloseOpenCursors();
         base.cleanup();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         com.genexus.Application.cleanup( base.context , this, remoteHandle);
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         subwgx001020 = new subwgx001020();
         scmdbuf = "" ;
         lV6cPesCPF = "" ;
         AV6cPesCPF = "" ;
         lV9cPesEnd = "" ;
         AV9cPesEnd = "" ;
         lV10cPesTe = "" ;
         AV10cPesTe = "" ;
         lV11cPesCe = "" ;
         AV11cPesCe = "" ;
         AV5cPesCod = 0 ;
         AV7cPesDat = (DateTime)(DateTime.MinValue) ;
         AV8cCidCod = 0 ;
         W00282_A26CidCodi = new int[1] ;
         W00282_n26CidCodi = new bool[] {false} ;
         W00282_A18PesEndN = new String[] {""} ;
         W00282_n18PesEndN = new bool[] {false} ;
         W00282_A21PesTele = new String[] {""} ;
         W00282_n21PesTele = new bool[] {false} ;
         W00282_A22PesCelu = new String[] {""} ;
         W00282_n22PesCelu = new bool[] {false} ;
         W00282_A111PesDat = new DateTime[] {DateTime.MinValue} ;
         W00282_n111PesDat = new bool[] {false} ;
         W00282_A15PesCPF = new String[] {""} ;
         W00282_n15PesCPF = new bool[] {false} ;
         W00282_A13PesCodi = new int[1] ;
         A26CidCodi = 0 ;
         n26CidCodi = false ;
         A18PesEndN = "" ;
         n18PesEndN = false ;
         A21PesTele = "" ;
         n21PesTele = false ;
         A22PesCelu = "" ;
         n22PesCelu = false ;
         A111PesDat = (DateTime)(DateTime.MinValue) ;
         n111PesDat = false ;
         A15PesCPF = "" ;
         n15PesCPF = false ;
         A13PesCodi = 0 ;
         gxIsRefreshing = false ;
         cV5cPesCod = 0 ;
         cV6cPesCPF = "" ;
         cV7cPesDat = (DateTime)(DateTime.MinValue) ;
         cV8cCidCod = 0 ;
         cV9cPesEnd = "" ;
         cV10cPesTe = "" ;
         cV11cPesCe = "" ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wgx0010__default(),
            new Object[][] {
                new Object[] {
               W00282_A26CidCodi, W00282_n26CidCodi, W00282_A18PesEndN, W00282_n18PesEndN, W00282_A21PesTele, W00282_n21PesTele, W00282_A22PesCelu, W00282_n22PesCelu, W00282_A111PesDat, W00282_n111PesDat,
               W00282_A15PesCPF, W00282_n15PesCPF, W00282_A13PesCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int AV5cPesCod ;
      protected int AV8cCidCod ;
      protected int A26CidCodi ;
      protected int A13PesCodi ;
      protected int cV5cPesCod ;
      protected int cV8cCidCod ;
      protected int AV12pPesCo ;
      protected String scmdbuf ;
      protected DateTime AV7cPesDat ;
      protected DateTime A111PesDat ;
      protected DateTime cV7cPesDat ;
      protected bool n26CidCodi ;
      protected bool n18PesEndN ;
      protected bool n21PesTele ;
      protected bool n22PesCelu ;
      protected bool n111PesDat ;
      protected bool n15PesCPF ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected String lV6cPesCPF ;
      protected String AV6cPesCPF ;
      protected String lV9cPesEnd ;
      protected String AV9cPesEnd ;
      protected String lV10cPesTe ;
      protected String AV10cPesTe ;
      protected String lV11cPesCe ;
      protected String AV11cPesCe ;
      protected String A18PesEndN ;
      protected String A21PesTele ;
      protected String A22PesCelu ;
      protected String A15PesCPF ;
      protected String cV6cPesCPF ;
      protected String cV9cPesEnd ;
      protected String cV10cPesTe ;
      protected String cV11cPesCe ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwgx001020 subwgx001020 ;
      protected IDataReader W00282 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W00282_A26CidCodi ;
      protected bool[] W00282_n26CidCodi ;
      protected String[] W00282_A18PesEndN ;
      protected bool[] W00282_n18PesEndN ;
      protected String[] W00282_A21PesTele ;
      protected bool[] W00282_n21PesTele ;
      protected String[] W00282_A22PesCelu ;
      protected bool[] W00282_n22PesCelu ;
      protected DateTime[] W00282_A111PesDat ;
      protected bool[] W00282_n111PesDat ;
      protected String[] W00282_A15PesCPF ;
      protected bool[] W00282_n15PesCPF ;
      protected int[] W00282_A13PesCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCpescodigo ;
      protected GUIObjectString edtavCpescpf ;
      protected GUIObjectDatetime edtavCpesdatnascimento ;
      protected GUIObjectInt edtavCcidcodigo ;
      protected GUIObjectString edtavCpesendnumero ;
      protected GUIObjectString edtavCpestelefone ;
      protected GUIObjectString edtavCpescelular ;
      protected GXSubfile subGrd_1 ;
      protected IGXButton bttBtn_enter ;
      protected IGXButton bttBtn_cancel ;
      protected IGXButton bttBtn_refresh ;
      protected IGXButton bttBtn_help ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl11 ;
      protected ILabel lbllbl13 ;
      protected ILabel lbllbl15 ;
      protected ILabel lbllbl17 ;
      protected ILabel lbllbl19 ;
      protected int aP0_pPesCodigo ;
   }

   public class wgx0010__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmW00282 ;
          prmW00282 = new Object[] {
          new Object[] {"@AV5cPesCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cPesCPF",SqlDbType.VarChar,14,0} ,
          new Object[] {"@AV7cPesDat",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8cCidCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV9cPesEnd",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV10cPesTe",SqlDbType.VarChar,13,0} ,
          new Object[] {"@AV11cPesCe",SqlDbType.VarChar,13,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W00282", "SELECT [CidCodigo], [PesEndNumero], [PesTelefone], [PesCelular], [PesDatNascimento], [PesCPF], [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE ([PesCodigo] >= @AV5cPesCod) AND ([PesCPF] like @AV6cPesCPF) AND ([PesDatNascimento] >= @AV7cPesDat) AND ([CidCodigo] >= @AV8cCidCod) AND ([PesEndNumero] like @AV9cPesEnd) AND ([PesTelefone] like @AV10cPesTe) AND ([PesCelular] like @AV11cPesCe) ORDER BY [PesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW00282,9,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((int[]) buf[12])[0] = rslt.getInt(7) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
