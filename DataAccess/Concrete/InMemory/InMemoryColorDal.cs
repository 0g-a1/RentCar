using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color> 
            {
                new Color{ColorId=1,ColorName="Kırmızı"},
                new Color{ColorId=2,ColorName="Beyaz"},
                new Color{ColorId=3,ColorName="Siyah"},
                new Color{ColorId=4,ColorName="Gümüş"}
            };
        }
        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(clr => clr.ColorId == color.ColorId);
            _colors.Remove(colorToDelete);
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetById(int colorId)
        {
            return _colors.Where(clr => clr.ColorId == colorId).ToList();
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(clr => clr.ColorId == color.ColorId);

            colorToUpdate.ColorId = color.ColorId;
            colorToUpdate.ColorName = color.ColorName;
        }
    }
}
