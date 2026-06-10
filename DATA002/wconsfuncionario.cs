/*
               File: ConsFuncionario
        Description: Consulta de funcionários.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:40:42.98
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
   public class wconsfuncionario : GXWorkpanel
   {
      public wconsfuncionario( int hnd ,
                               ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wconsfuncionario( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wconsfuncionario( IGxContext context ,
                               int hnd ,
                               ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "ConsFuncionario" ;
      }

      public override String getFrmTitle( )
      {
         return "Consulta de funcionários." ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return null;
      }

      public override bool useCallersMenuBar( )
      {
         return true;
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
         return 702 ;
      }

      public override int getFrmHeight( )
      {
         return 741 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WConsFuncionario.htm";
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

      public void execute( out int aP0_PesCodigoRet )
      {
         this.AV5PesCodi = 0 ;
         executePrivate();
         aP0_PesCodigoRet=this.AV5PesCodi;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load12( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwconsfuncionario12 = new subwconsfuncionario12 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV11PesCod ,
                                              AV6PesNome ,
                                              AV7PesFunC ,
                                              AV8PesFunD ,
                                              A13PesCodi ,
                                              A14PesNome ,
                                              A39PesFunC ,
                                              A42PesFunD ,
                                              A38PesTipo },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W000T2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf12.getSize() < 10000 ) ) )
         {
            A38PesTipo = W000T2_A38PesTipo[0] ;
            n38PesTipo = W000T2_n38PesTipo[0] ;
            A42PesFunD = W000T2_A42PesFunD[0] ;
            n42PesFunD = W000T2_n42PesFunD[0] ;
            A41PesFunD = W000T2_A41PesFunD[0] ;
            n41PesFunD = W000T2_n41PesFunD[0] ;
            A39PesFunC = W000T2_A39PesFunC[0] ;
            n39PesFunC = W000T2_n39PesFunC[0] ;
            A14PesNome = W000T2_A14PesNome[0] ;
            n14PesNome = W000T2_n14PesNome[0] ;
            A13PesCodi = W000T2_A13PesCodi[0] ;
            /* Execute user event: E11V0T2 */
            E11V0T2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf12.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class ConsFuncionario_load12 : GXLoadProducer
      {
         wconsfuncionario _sf ;

         public ConsFuncionario_load12( wconsfuncionario uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer12();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load12();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors12();
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
            subGxsf12.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow12( )
      {
         return true;
      }

      public void autoRefresh_flow12( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow12() )) {
            subfile.refresh();
            resetSubfileConditions_flow12() ;
         }
      }

      public bool getSearch_flow12( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow12( )
      {
      }

      public void resetSearchConditions_flow12( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow12( )
      {
         return new subwconsfuncionario12 ();
      }

      public bool getSearch_flow12( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow12( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow12( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow12( )
      {
         GXRefreshCommand12 ();
      }

      public class ConsFuncionario_flow12 : GXSubfileFlow
      {
         wconsfuncionario _sf ;

         public ConsFuncionario_flow12( wconsfuncionario uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow12();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow12(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow12();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow12();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow12(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow12();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow12(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow12(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow12(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow12();
         }

      }

      protected void GXRefreshCommand12( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public void loadToBuffer12( )
      {
         subwconsfuncionario12 oAux = subwconsfuncionario12 ;
         subwconsfuncionario12 = new subwconsfuncionario12 ();
         variablesToSubfile12 ();
         subGxsf12.addElement(subwconsfuncionario12);
         subwconsfuncionario12 = oAux;
      }

      private void E11V0T2( )
      {
         AV10Demiti = 0 ;
         /* Load Routine */
         AV10Demiti = 0 ;
         if ( ( A41PesFunD != DateTimeUtil.CToD( "0", 2) ) )
         {
            AV10Demiti = 1 ;
         }
         subGxsf12.loadCommand();
      }

      protected void closeCursors12( )
      {
         pr_default.close(0);
      }

      public override void GXExit( )
      {
         /* Execute user event: E12V0T2 */
         E12V0T2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
            }
            if (true) return;
         }
      }

      protected void E12V0T2( )
      {
         eventLevelContext();
         /* Exit Routine */
         AV5PesCodi = A13PesCodi ;
         edtavPescodigoret.setValue(AV5PesCodi);
      }

      protected void E13V0T2( )
      {
         eventLevelContext();
         /* PesCodigo_Click Routine */
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
      }

      protected void E14V0T2( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A13PesCodi") )
         {
            new wconsfuncionario(context, base.remoteHandle, base.context).execute( out  A13PesCodi) ;
            ((subwconsfuncionario12)subGxsf12.getCurrentElement()).setPesCodigo(A13PesCodi);
            subGxsf12.refreshLineValue(subGxsf12.getSelectedElement());
            subGxsf12.repaint();
         }
         eventLevelResetContext();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 702 , 741 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavPescodigoret = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),117, 65, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 117 , 65 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV5PesCodi" );
         ((GXEdit) edtavPescodigoret.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavPescodigoret.addFocusListener(this);
         edtavPescodigoret.getGXComponent().setHelpId("HLP_WConsFuncionario.htm");
         edtavPesnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),273, 65, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 273 , 65 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6PesNome" );
         ((GXEdit) edtavPesnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesnome.addFocusListener(this);
         edtavPesnome.getGXComponent().setHelpId("HLP_WConsFuncionario.htm");
         cmbavPesfuncargo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 117 , 91 , 82 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7PesFunC" );
         ((GXComboBox) cmbavPesfuncargo.getGXComponent()).addItem( new java.lang.Short(1),"Gerente");
         ((GXComboBox) cmbavPesfuncargo.getGXComponent()).addItem( new java.lang.Short(2),"Vendedor");
         cmbavPesfuncargo.addFocusListener(this);
         cmbavPesfuncargo.addItemListener(this);
         cmbavPesfuncargo.getGXComponent().setHelpId("HLP_WConsFuncionario.htm");
         edtavPesfundatadmissao = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),273, 91, 104, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 273 , 91 , 104 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8PesFunD" );
         ((GXEdit) edtavPesfundatadmissao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesfundatadmissao.addFocusListener(this);
         edtavPesfundatadmissao.getGXComponent().setHelpId("HLP_WConsFuncionario.htm");
         edtavPesfundatdemissao = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),455, 91, 104, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 455 , 91 , 104 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9PesFunD" );
         ((GXEdit) edtavPesfundatdemissao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesfundatdemissao.addFocusListener(this);
         edtavPesfundatdemissao.getGXComponent().setHelpId("HLP_WConsFuncionario.htm");
         addSubfile ( subGxsf12  = new GXSubfile ( new ConsFuncionario_load12(this), new ConsFuncionario_flow12(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 71, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 70 , 18 , UIFactory.getColor(5) , UIFactory.getColor(255, 0, 0) , UIFactory.getFont( "Courier New", 0, 9) , false , "A13PesCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 70 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 261, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 260 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A14PesNome" ), "Nome completo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 260 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 125 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A39PesFunC" ), "Cargo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 125 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 78, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 77 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A41PesFunD" ), "Demissão"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 77 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectShort ( new GXCheckBox(GXPanel1, "" , new java.lang.Short(1), new java.lang.Short(0)) , null ,  0 , 0 , 58 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV10Demiti" ), "Demitido"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 58 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         }, 33 , 18 , GXPanel1 , 65 , 117 , 573 , 611 ,  18 ));
         ((GXComboBox) subGxsf12.getColumn(2).getGXComponent()).addItem( new java.lang.Short(1),"Gerente");
         ((GXComboBox) subGxsf12.getColumn(2).getGXComponent()).addItem( new java.lang.Short(2),"Vendedor");
         subGxsf12.addActionListener(this);
         subGxsf12.addFocusListener(this);
         subGxsf12.setSortOnClick(true);
         subGxsf12.getColumn(0).addActionListener( this);
         subGxsf12.getColumn(0).addItemListener( this);
         lbllbl18 = UIFactory.getLabel(GXPanel1, "Consulta de funcionários", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 141 , 13 );
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 65 , 40 , 13 );
         lbllbl8 = UIFactory.getLabel(GXPanel1, "Nome", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 208 , 65 , 33 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Cargo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 91 , 34 , 13 );
         lbllbl10 = UIFactory.getLabel(GXPanel1, "Admissão", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 208 , 91 , 54 , 13 );
         lbllbl11 = UIFactory.getLabel(GXPanel1, "Demissão", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 390 , 91 , 55 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavPescodigoret ,
                   edtavPesnome ,
                   cmbavPesfuncargo ,
                   edtavPesfundatadmissao ,
                   edtavPesfundatdemissao ,
                   subGxsf12
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf12, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile12( )
      {
         subwconsfuncionario12.setPesCodigo(A13PesCodi);
         subwconsfuncionario12.setPesNome(A14PesNome);
         subwconsfuncionario12.setPesFunCargo(A39PesFunC);
         subwconsfuncionario12.setPesFunDatDemissao(A41PesFunD);
         subwconsfuncionario12.setVDemitido(AV10Demiti);
      }

      protected void subfileToVariables12( )
      {
         A13PesCodi = subwconsfuncionario12.getPesCodigo();
         A14PesNome = subwconsfuncionario12.getPesNome();
         A39PesFunC = subwconsfuncionario12.getPesFunCargo();
         A41PesFunD = subwconsfuncionario12.getPesFunDatDemissao();
         AV10Demiti = subwconsfuncionario12.getVDemitido();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavPescodigoret.setValue( AV5PesCodi );
         cmbavPesfuncargo.setValue( AV7PesFunC );
         edtavPesfundatadmissao.setValue( AV8PesFunD );
         edtavPesfundatdemissao.setValue( AV9PesFunD );
         edtavPesnome.setValue( AV6PesNome );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5PesCodi = (int)(edtavPescodigoret.getValue()) ;
         edtavPescodigoret.setValue(AV5PesCodi);
         AV7PesFunC = (short)(cmbavPesfuncargo.getValue()) ;
         cmbavPesfuncargo.setValue(AV7PesFunC);
         AV8PesFunD = (DateTime)(edtavPesfundatadmissao.getValue()) ;
         edtavPesfundatadmissao.setValue(AV8PesFunD);
         AV9PesFunD = (DateTime)(edtavPesfundatdemissao.getValue()) ;
         edtavPesfundatdemissao.setValue(AV9PesFunD);
         AV6PesNome = (String)(edtavPesnome.getValue()) ;
         edtavPesnome.setValue(AV6PesNome);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf12.inValidElement() )
         {
            subwconsfuncionario12 = ( subwconsfuncionario12 ) subGxsf12.getCurrentElement() ;
         }
         else
         {
            subwconsfuncionario12 = new subwconsfuncionario12 ();
         }
         subfileToVariables12 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile12 ();
         subGxsf12.refreshLineValue(subwconsfuncionario12);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf12.inValidElement() )
         {
            subwconsfuncionario12 = ( subwconsfuncionario12 ) subGxsf12.getCurrentElement() ;
         }
         else
         {
            subwconsfuncionario12 = new subwconsfuncionario12 ();
         }
         subfileToVariables12 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( subGxsf12.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf12.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E13V0T2 */
            E13V0T2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavPescodigoret.isEventSource(eventSource) ) {
            setGXCursor( edtavPescodigoret.getGXCursor() );
            return;
         }
         if ( cmbavPesfuncargo.isEventSource(eventSource) ) {
            setGXCursor( cmbavPesfuncargo.getGXCursor() );
            return;
         }
         if ( edtavPesfundatadmissao.isEventSource(eventSource) ) {
            setGXCursor( edtavPesfundatadmissao.getGXCursor() );
            return;
         }
         if ( edtavPesfundatdemissao.isEventSource(eventSource) ) {
            setGXCursor( edtavPesfundatdemissao.getGXCursor() );
            return;
         }
         if ( edtavPesnome.isEventSource(eventSource) ) {
            setGXCursor( edtavPesnome.getGXCursor() );
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
         if ( edtavPescodigoret.isEventSource(eventSource) ) {
            AV5PesCodi = edtavPescodigoret.getValue() ;
            return;
         }
         if ( cmbavPesfuncargo.isEventSource(eventSource) ) {
            AV7PesFunC = cmbavPesfuncargo.getValue() ;
            return;
         }
         if ( edtavPesfundatadmissao.isEventSource(eventSource) ) {
            AV8PesFunD = edtavPesfundatadmissao.getValue() ;
            return;
         }
         if ( edtavPesfundatdemissao.isEventSource(eventSource) ) {
            AV9PesFunD = edtavPesfundatdemissao.getValue() ;
            return;
         }
         if ( edtavPesnome.isEventSource(eventSource) ) {
            AV6PesNome = edtavPesnome.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf12.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E13V0T2 */
            E13V0T2 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E14V0T2 */
            E14V0T2 ();
            return true ;
         }
         if (triggerEventEnter(eventSource, keyCode)) {
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
            /* Execute user event: E12V0T2 */
            E12V0T2 ();
         }
         this.AV5PesCodi = AV5PesCodi;
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
         subwconsfuncionario12 = new subwconsfuncionario12();
         scmdbuf = "" ;
         AV11PesCod = 0 ;
         AV6PesNome = "" ;
         AV7PesFunC = 0 ;
         AV8PesFunD = (DateTime)(DateTime.MinValue) ;
         A13PesCodi = 0 ;
         A14PesNome = "" ;
         A39PesFunC = 0 ;
         A42PesFunD = (DateTime)(DateTime.MinValue) ;
         A38PesTipo = 0 ;
         W000T2_A38PesTipo = new short[1] ;
         W000T2_n38PesTipo = new bool[] {false} ;
         W000T2_A42PesFunD = new DateTime[] {DateTime.MinValue} ;
         W000T2_n42PesFunD = new bool[] {false} ;
         W000T2_A41PesFunD = new DateTime[] {DateTime.MinValue} ;
         W000T2_n41PesFunD = new bool[] {false} ;
         W000T2_A39PesFunC = new short[1] ;
         W000T2_n39PesFunC = new bool[] {false} ;
         W000T2_A14PesNome = new String[] {""} ;
         W000T2_n14PesNome = new bool[] {false} ;
         W000T2_A13PesCodi = new int[1] ;
         n38PesTipo = false ;
         n42PesFunD = false ;
         A41PesFunD = (DateTime)(DateTime.MinValue) ;
         n41PesFunD = false ;
         n39PesFunC = false ;
         n14PesNome = false ;
         gxIsRefreshing = false ;
         AV10Demiti = 0 ;
         returnInSub = false ;
         AV9PesFunD = (DateTime)(DateTime.MinValue) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wconsfuncionario__default(),
            new Object[][] {
                new Object[] {
               W000T2_A38PesTipo, W000T2_n38PesTipo, W000T2_A42PesFunD, W000T2_n42PesFunD, W000T2_A41PesFunD, W000T2_n41PesFunD, W000T2_A39PesFunC, W000T2_n39PesFunC, W000T2_A14PesNome, W000T2_n14PesNome,
               W000T2_A13PesCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV7PesFunC ;
      protected short A39PesFunC ;
      protected short A38PesTipo ;
      protected short AV10Demiti ;
      protected int AV11PesCod ;
      protected int A13PesCodi ;
      protected int AV5PesCodi ;
      protected String scmdbuf ;
      protected DateTime AV8PesFunD ;
      protected DateTime A42PesFunD ;
      protected DateTime A41PesFunD ;
      protected DateTime AV9PesFunD ;
      protected bool n38PesTipo ;
      protected bool n42PesFunD ;
      protected bool n41PesFunD ;
      protected bool n39PesFunC ;
      protected bool n14PesNome ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected String AV6PesNome ;
      protected String A14PesNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwconsfuncionario12 subwconsfuncionario12 ;
      protected IDataReader W000T2 ;
      protected IDataStoreProvider pr_default ;
      protected short[] W000T2_A38PesTipo ;
      protected bool[] W000T2_n38PesTipo ;
      protected DateTime[] W000T2_A42PesFunD ;
      protected bool[] W000T2_n42PesFunD ;
      protected DateTime[] W000T2_A41PesFunD ;
      protected bool[] W000T2_n41PesFunD ;
      protected short[] W000T2_A39PesFunC ;
      protected bool[] W000T2_n39PesFunC ;
      protected String[] W000T2_A14PesNome ;
      protected bool[] W000T2_n14PesNome ;
      protected int[] W000T2_A13PesCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavPescodigoret ;
      protected GUIObjectString edtavPesnome ;
      protected GUIObjectShort cmbavPesfuncargo ;
      protected GUIObjectDatetime edtavPesfundatadmissao ;
      protected GUIObjectDatetime edtavPesfundatdemissao ;
      protected GXSubfile subGxsf12 ;
      protected ILabel lbllbl18 ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl8 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl10 ;
      protected ILabel lbllbl11 ;
      protected int aP0_PesCodigoRet ;
   }

   public class wconsfuncionario__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000T2( int AV11PesCod ,
                                           String AV6PesNome ,
                                           short AV7PesFunC ,
                                           DateTime AV8PesFunD ,
                                           int A13PesCodi ,
                                           String A14PesNome ,
                                           short A39PesFunC ,
                                           DateTime A42PesFunD ,
                                           short A38PesTipo )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [PesTipo], [PesFunDatAdmissao], [PesFunDatDemissao], [PesFunCargo], [PesNome], [PesCodigo] FROM [PESSOA] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([PesTipo] = 2)" ;
         sWhereString = "" ;
         if ( ( AV11PesCod != 0 ) )
         {
            sWhereString = sWhereString + " and ([PesCodigo] = " + StringUtil.Str( (decimal)(AV11PesCod), 9, 0) + ")" ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV6PesNome).TrimEnd(' ') )==0)) )
         {
            sWhereString = sWhereString + " and ([PesNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6PesNome, "'", "''")), 50, "%") + "')" ;
         }
         if ( ( AV7PesFunC != 0 ) )
         {
            sWhereString = sWhereString + " and ([PesFunCargo] = " + StringUtil.Str( (decimal)(AV7PesFunC), 1, 0) + ")" ;
         }
         if ( ( AV8PesFunD != DateTimeUtil.CToD( "0", 2) ) )
         {
            sWhereString = sWhereString + " and ([PesFunDatAdmissao] = " + ((AV8PesFunD>DateTimeUtil.CToD( "01/01/1753", 3)) ? "convert( DATETIME,'"+DateTimeUtil.DToC( AV8PesFunD, 0, "-")+"',102)" : "convert( DATETIME, '17530101', 112 )") + ")" ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY [PesCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W000T2( (int)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (DateTime)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (DateTime)dynConstraints[7] , (short)dynConstraints[8] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

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
          Object[] prmW000T2 ;
          prmW000T2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000T2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000T2,27,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((int[]) buf[10])[0] = rslt.getInt(6) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
