using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GlassCannon.Armor.ArmoredArmors.ArmoredGlassArmor;

namespace GlassCannon.Armor.ArmoredArmors.TrueArmoredGlassArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class TrueArmoredGlassArmorHelmet : ModItem
	{


		public override void SetDefaults()
		{
			Item.width = 12;
			Item.height = 12;
			Item.value = 2000;
			Item.rare = 8;
			Item.defense = 25;
		}

        public override void UpdateArmorSet(Player player)
        {

            if (player.statLifeMax == 500)
            {
                player.setBonus = "ACTIVE MK2 !!";
                player.GetAttackSpeed(DamageClass.Melee) += 0.20f;
                player.GetDamage(DamageClass.Melee) += 0.20f;
                player.GetCritChance(DamageClass.Melee) += 20;
                player.statDefense += 30;
                player.aggro += 1600;
                player.noKnockback = true;
                player.moveSpeed -= 0.2f;
                player.maxRunSpeed -= 0.2f;


                if (player.statLife < 0.60 * player.statLifeMax2 && player.statLife > 0.30 * player.statLifeMax2)
                {
                    player.GetAttackSpeed(DamageClass.Melee) -= 0.10f;
                    player.GetDamage(DamageClass.Melee) -= 0.10f;
                    player.GetCritChance(DamageClass.Melee) -= 10;
                    player.statDefense *= 1.50f;
                    player.aggro += 800;
                    player.moveSpeed -= 0.2f;
                    player.maxRunSpeed -= 0.2f;

                }
                else if (player.statLife < 0.30 * player.statLifeMax2)
                {
                    player.GetAttackSpeed(DamageClass.Melee) -= 0.10f;
                    player.GetDamage(DamageClass.Melee) -= 0.10f;
                    player.GetCritChance(DamageClass.Melee) -= 10;
                    player.statDefense *= 1.50f;
                    player.aggro += 800;
                    player.moveSpeed -= 0.2f;
                    player.maxRunSpeed -= 0.2f;
                    player.endurance += 1;

                }
            }
            else if (player.statLifeMax == 525)
            {
                player.setBonus = "ACTIVE MK3 !!";
                player.GetAttackSpeed(DamageClass.Melee) += 0.25f;
                player.GetDamage(DamageClass.Melee) += 0.25f;
                player.GetCritChance(DamageClass.Melee) += 25;
                player.statDefense += 40;
                player.aggro += 1600;
                player.noKnockback = true;
                player.moveSpeed -= 0.2f;
                player.maxRunSpeed -= 0.2f;

                if (player.statLife < 0.60 * player.statLifeMax2 && player.statLife > 0.30 * player.statLifeMax2)
                {
                    player.GetAttackSpeed(DamageClass.Melee) -= 0.10f;
                    player.GetDamage(DamageClass.Melee) -= 0.10f;
                    player.GetCritChance(DamageClass.Melee) -= 10;
                    player.statDefense *= 1.5f;
                    player.aggro += 800;
                    player.moveSpeed -= 0.2f;
                    player.maxRunSpeed -= 0.2f;
                    player.endurance += 1;

                }
                else if (player.statLife < 0.30 * player.statLifeMax2)
                {
                    player.GetAttackSpeed(DamageClass.Melee) -= 0.15f;
                    player.GetDamage(DamageClass.Melee) -= 0.15f;
                    player.GetCritChance(DamageClass.Melee) -= 15;
                    player.statDefense *= 1.5f;
                    player.aggro += 800;
                    player.moveSpeed -= 0.2f;
                    player.maxRunSpeed -= 0.2f;
                    player.endurance += 1;

                }
            }
            else if (player.statLifeMax == 550 )
            {
                player.setBonus = "ACTIVE MK4 !!";
                player.GetAttackSpeed(DamageClass.Melee) += 0.30f;
                player.GetDamage(DamageClass.Melee) += 0.30f;
                player.GetCritChance(DamageClass.Melee) += 30;
                player.statDefense += 50;
                player.aggro += 1600;
                player.noKnockback = true;
                player.moveSpeed -= 0.2f;
                player.maxRunSpeed -= 0.2f;

                if (player.statLife < 0.60 * player.statLifeMax2 && player.statLife > 0.30 * player.statLifeMax2)
                {
                    player.GetAttackSpeed(DamageClass.Melee) -= 0.15f;
                    player.GetDamage(DamageClass.Melee) -= 0.15f;
                    player.GetCritChance(DamageClass.Melee) -= 15;
                    player.statDefense *= 1.5f;
                    player.aggro += 800;
                    player.moveSpeed -= 0.2f;
                    player.maxRunSpeed -= 0.2f;

                }
                else if (player.statLife < 0.30 * player.statLifeMax2)
                {
                    player.GetAttackSpeed(DamageClass.Melee) -= 0.15f;
                    player.GetDamage(DamageClass.Melee) -= 0.15f;
                    player.GetCritChance(DamageClass.Melee) -= 15;
                    player.statDefense *= 1.5f;
                    player.aggro += 800;
                    player.moveSpeed -= 0.2f;
                    player.maxRunSpeed -= 0.2f;
                    player.endurance += 1;

                }
            }
            else if (player.statLifeMax == 575)
            {
                player.setBonus = "ACTIVE MK5 !!";
                player.GetAttackSpeed(DamageClass.Melee) += 0.35f;
                player.GetDamage(DamageClass.Melee) += 0.35f;
                player.GetCritChance(DamageClass.Melee) += 35;
                player.statDefense += 60;
                player.aggro += 1600;
                player.noKnockback = true;
                player.moveSpeed -= 0.2f;
                player.maxRunSpeed -= 0.2f;

                if (player.statLife < 0.60 * player.statLifeMax2 && player.statLife > 0.30 * player.statLifeMax2)
                {
                    player.GetAttackSpeed(DamageClass.Melee) -= 0.15f;
                    player.GetDamage(DamageClass.Melee) -= 0.15f;
                    player.GetCritChance(DamageClass.Melee) -= 15;
                    player.statDefense *= 1.5f;
                    player.aggro += 800;
                    player.moveSpeed -= 0.2f;
                    player.maxRunSpeed -= 0.2f;

                }
                else if (player.statLife < 0.30 * player.statLifeMax2)
                {
                    player.GetAttackSpeed(DamageClass.Melee) -= 0.20f;
                    player.GetDamage(DamageClass.Melee) -= 0.20f;
                    player.GetCritChance(DamageClass.Melee) -= 20;
                    player.statDefense *= 1.5f;
                    player.aggro += 800;
                    player.moveSpeed -= 0.2f;
                    player.maxRunSpeed -= 0.2f;
                    player.endurance += 1;

                }
            }
            if (player.statLifeMax >= 600 && player.statLifeMax2 <= 1500)
            {
                player.setBonus = "ACTIVE MK6 !!";
                player.GetAttackSpeed(DamageClass.Melee) += 0.40f;
                player.GetDamage(DamageClass.Melee) += 0.40f;
                player.GetCritChance(DamageClass.Melee) += 40;
                player.statDefense += 70;
                player.aggro += 1600;
                player.noKnockback = true;
                player.moveSpeed -= 0.2f;
                player.maxRunSpeed -= 0.2f;

                if (player.statLife < 0.60 * player.statLifeMax2 && player.statLife > 0.30 * player.statLifeMax2)
                {
                    player.GetAttackSpeed(DamageClass.Melee) -= 0.15f;
                    player.GetDamage(DamageClass.Melee) -= 0.15f;
                    player.GetCritChance(DamageClass.Melee) -= 15;
                    player.statDefense *= 1.5f;
                    player.aggro += 800;
                    player.moveSpeed -= 0.2f;
                    player.maxRunSpeed -= 0.2f;

                }
                else if (player.statLife < 0.30 * player.statLifeMax2)
                {
                    player.GetAttackSpeed(DamageClass.Melee) -= 0.25f;
                    player.GetDamage(DamageClass.Melee) -= 0.25f;
                    player.GetCritChance(DamageClass.Melee) -= 25;
                    player.statDefense *= 1.5f;
                    player.aggro += 800;
                    player.moveSpeed -= 0.2f;
                    player.maxRunSpeed -= 0.2f;
                    player.endurance += 1;

                }
            }
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
		    if (body.type == Mod.Find<ModItem>("TrueArmoredGlassArmorShirt").Type)
			{
				    return legs.type == Mod.Find<ModItem>("TrueArmoredGlassArmorPants").Type;
			}
			return false;
		}
            
            


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LunarBar, 15);
            recipe.AddIngredient(ItemID.LifeCrystal, 2);
            recipe.AddIngredient(ItemID.FragmentSolar, 10);
            recipe.AddIngredient(ItemID.EndurancePotion, 1);
            recipe.AddIngredient(ModContent.ItemType<ArmoredGlassArmorHelmet>());
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

    }
}
