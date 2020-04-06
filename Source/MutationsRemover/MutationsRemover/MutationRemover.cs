using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace MutationRemover
{
    [DefOf]
    public static class HediffDefOf
    {

        static HediffDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(HediffDefOf));
        }

        public static HediffDef UrsaSleep;
        public static HediffDef UrsaSlow;
        public static HediffDef UrsaFur;
        public static HediffDef UrsaDisfigured;
        public static HediffDef UrsaWild;
        public static HediffDef SilFlowers;
        public static HediffDef SilStomach;
        public static HediffDef SilBlood;
        public static HediffDef SilSkin;
        public static HediffDef SilDegraded;
        public static HediffDef SilCalm;
        public static HediffDef MyrolStatic;
        public static HediffDef MyrolMyrolsis;
        public static HediffDef MyrolLung;
        public static HediffDef MidiaSmart;
        public static HediffDef MidiaForget;
        public static HediffDef MidiaRough;
        public static HediffDef MidiaKeen;
        public static HediffDef MidiaAbsent;
        public static HediffDef IgniSpeed;
        public static HediffDef IgniRage;
        public static HediffDef IgniWarm;
        public static HediffDef IgniFurnace;
        public static HediffDef IgniStrongBack;
        public static HediffDef SlurryWithering;
        public static HediffDef SlurrySlimy;
        public static HediffDef SlurryWired;
        public static HediffDef SlurryStrong;
        public static HediffDef SlurryAgile;
        public static HediffDef SlurryStagnant;
        public static HediffDef SlurrySooth;
    }

    public class CompUseEffect_MutationRemover : CompUseEffect
    {
        public override void DoEffect(Pawn user)
        {
            Hediff hediff = null;
            int numcheck = 0;
        	List<Hediff> hediffs = user.health.hediffSet.hediffs;
	        for (int i = 0; i < hediffs.Count; i++)
	        {
                hediff = hediffs[i];
                if (hediff.def == HediffDefOf.UrsaSleep)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.UrsaSlow)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.UrsaFur)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.UrsaDisfigured)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.UrsaWild)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SilFlowers)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SilStomach)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SilBlood)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SilSkin)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SilDegraded)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SilCalm)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.MyrolStatic)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.MyrolMyrolsis)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.MyrolLung)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.MidiaSmart)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.MidiaForget)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.MidiaRough)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.MidiaKeen)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.MidiaAbsent)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.IgniSpeed)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.IgniRage)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.IgniWarm)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.IgniFurnace)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.IgniStrongBack)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SlurryWithering)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SlurrySlimy)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SlurryWired)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SlurryStrong)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SlurryAgile)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SlurryStagnant)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
                if (hediff.def == HediffDefOf.SlurrySooth)
                {
                    this.Cure(hediff);
                    numcheck += 1;
                }
            }

            if (numcheck < 1)
            {
                Messages.Message("Genome mech serum had no effect!", MessageTypeDefOf.NegativeEvent, true);
            }
        }

        private void Cure(Hediff hediff)
        {
            Pawn pawn = hediff.pawn;
            pawn.health.RemoveHediff(hediff);
            if (hediff.def.cureAllAtOnceIfCuredByItem)
            {
                int num = 0;
                for (; ; )
                {
                    num++;
                    if (num > 10000)
                    {
                        break;
                    }
                    Hediff firstHediffOfDef = pawn.health.hediffSet.GetFirstHediffOfDef(hediff.def, false);
                    if (firstHediffOfDef == null)
                    {
                        goto IL_64;
                    }
                    pawn.health.RemoveHediff(firstHediffOfDef);
                }
                Log.Error("Too many iterations.", false);
            }
        IL_64:
            Messages.Message("MessageHediffCuredByItem".Translate(hediff.LabelBase.CapitalizeFirst()), pawn, MessageTypeDefOf.PositiveEvent, true);
        }
    }
}
